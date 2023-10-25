using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Model
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }
        [StringLength(100, ErrorMessage = "A descrição deve ter no máximo {1} caracteres.")]

        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; } = new List<Produto>();

    }
}
