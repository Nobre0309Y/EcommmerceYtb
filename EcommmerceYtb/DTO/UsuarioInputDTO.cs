using System.ComponentModel.DataAnnotations;

namespace EcommmerceYtb.DTO
{
    public class UsuarioInputDTO
    {
        [Key]
        public int UsuarioId { get; set; }
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }
        [RegularExpression(@"^[0-9]{11}", ErrorMessage = "O CPF deve ser numérico com 11 dígitos.")]
        public string Cpf { get; set; }
    }
}
