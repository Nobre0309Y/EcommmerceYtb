using Ecommerce.Model;
using EcommmerceYtb.DTO;

namespace EcommmerceYtb.Repository.Interface
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetAllAsync();
        Task<Usuario?> GetById(int id);
        Task<Usuario?> GetByCpf(string cpf);
        void AddUsuarios(UsuarioInputDTO model);



    }
}
