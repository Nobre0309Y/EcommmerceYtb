using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Ecommerce.Model
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [StringLength(50, ErrorMessage = "A descrição deve ter no máximo {1} caracteres.")]
        public string Descricao { get; set; }
        public int CategoriaId { get; set; }
        public List<Compra> Compras { get; set; } = new List<Compra>();
        public Categoria? Categoria { get; set; }
    }
}
