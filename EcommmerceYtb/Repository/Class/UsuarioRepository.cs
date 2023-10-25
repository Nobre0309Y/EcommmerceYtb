using Ecommerce.Data;
using Ecommerce.Model;
using EcommmerceYtb.DTO;
using EcommmerceYtb.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace EcommmerceYtb.Repository.Class
{
    public class UsuariosRepository : IUsuarioRepository

    {
        private readonly DataContext _dataContext;
        public UsuariosRepository(DataContext dataContext)
        {
            _dataContext = dataContext; 
        }
        public async Task<List<Usuario>> GetAllAsync()
        {
            return await _dataContext.Usuarios.ToListAsync();
        }

        public async Task<Usuario?> GetById(int id)
        {
            return await _dataContext.Usuarios.Where(x => x.UsuarioId == id).FirstOrDefaultAsync();
        }
        public async Task<Usuario?> GetByCpf(string cpf)
        {
            return await _dataContext.Usuarios.Where(x => x.Cpf == cpf).FirstOrDefaultAsync();
        }

        public void AddUsuarios(UsuarioInputDTO model)
        {
             _dataContext.Usuarios.AddAsync(ToUsuario(model));
             _dataContext.SaveChanges();
            return;
        }

        public Usuario ToUsuario(UsuarioInputDTO model)
        {
            return new Usuario
            {
                Cpf = model.Cpf,
                UsuarioId = model.UsuarioId,
                Nome = model.Nome,
            };
        }
    }
}
