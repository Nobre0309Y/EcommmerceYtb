using Ecommerce.Data;
using Ecommerce.Model;
using EcommmerceYtb.DTO;
using EcommmerceYtb.Repository.Class;
using EcommmerceYtb.Repository.Interface;
using EcommmerceYtb.Service.Class;
using EcommmerceYtb.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace EcommmerceYtb.Controllers
{
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuariosRepository;
        private readonly IUsuarioService _usuarioService;
        

        public UsuariosController (IUsuarioRepository UsuariosRepository, IUsuarioService usuarioService)
        {
            _usuariosRepository = UsuariosRepository;
            _usuarioService = usuarioService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var allUsuarioss = await _usuariosRepository.GetAllAsync();
            return Ok(allUsuarioss);
        }


        [HttpGet("GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            var Usuarios = await _usuariosRepository.GetById(id);
            return Ok(Usuarios);
        }

        [HttpGet("GetByCpf")]
        public async Task<ActionResult> GetByCpf(string cpf)
        {
            var Usuarios = await _usuariosRepository.GetByCpf(cpf);
            return Ok(Usuarios);    
        }

        [HttpPost("addUsuarios")]
        public async Task<ActionResult> AddUsuarios([FromBody]UsuarioInputDTO model)
        {
            if (model == null) return BadRequest("Inválido.");
            var teste = _usuarioService.AddUsuarios(model);
            if (teste != "")
            {
                return BadRequest($"{teste}");
            }
                
            _usuariosRepository.AddUsuarios(model);
            return Ok();
        }
        [HttpDelete("DelUsuario")]
        public async Task<ActionResult> DelUsuario(int id)
        {
            var teste = await _usuariosRepository.DelUsuario(id);
            if (teste != "sucess")
            {
                return BadRequest(teste);
            }
            return Ok("Deletado");
        }

    }
}
