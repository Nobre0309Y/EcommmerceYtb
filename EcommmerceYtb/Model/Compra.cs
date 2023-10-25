using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Model
{
    public class Compra
    {
        [Key]
        public int CompraId { get; set; }
        [Required(ErrorMessage = "Informe o Usuário.")]
        public int UsuariosId { get; set; }
        [Required(ErrorMessage = "Informe o Produto.")]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage ="Informe o Valor.")]
        public int Valor { get; set; }
        public DateTime DataCompra { get; set; }
        [StringLength(100, ErrorMessage = "O endereco deve ter no máximo {1} caracteres.")]
        public string Endereco { get; set; }

        public Usuario? Usuario { get; set; }
        public Produto? Produto { get; set; }

    }
}
