using Ecommerce.Data;
using EcommmerceYtb.DTO;
using EcommmerceYtb.Repository.Interface;
using EcommmerceYtb.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EcommmerceYtb.Service.Class
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DataContext _dataContext;
        public UsuarioService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public string AddUsuarios(UsuarioInputDTO model)
        {
            if (_dataContext.Usuarios.Where(x => x.Cpf == model.Cpf).FirstOrDefault() != null)
            {
                return "Cpf já cadastrado no sistema";
            }
            return "";
        }

    }
}

