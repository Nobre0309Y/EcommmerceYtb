using Ecommerce.Data;
using Ecommerce.Model;
using EcommmerceYtb.DTO;
using EcommmerceYtb.Repository.Class;
using EcommmerceYtb.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace EcommmerceYtb.Controllers
{
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _UsuariosRepository;
        

        public UsuariosController (IUsuarioRepository UsuariosRepository)
        {
            _UsuariosRepository = UsuariosRepository;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAll()
        {
            var allUsuarioss = await _UsuariosRepository.GetAllAsync();
            return Ok(allUsuarioss);
        }


        [HttpGet("GetById")]
        public async Task<ActionResult> GetById(int id)
        {
            var Usuarios = await _UsuariosRepository.GetById(id);
            return Ok(Usuarios);
        }

        [HttpGet("GetByCpf")]
        public async Task<ActionResult> GetByCpf(string cpf)
        {
            var Usuarios = await _UsuariosRepository.GetByCpf(cpf);
            return Ok(Usuarios);
        }

        [HttpPost("addUsuarios")]
        public async Task<ActionResult> AddUsuarios([FromBody]UsuarioInputDTO model)
        {
            if (model == null) return BadRequest("Inválido.");
            _UsuariosRepository.AddUsuarios(model);
            return Ok();
        }
    }
}
