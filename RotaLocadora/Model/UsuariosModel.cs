using RotaLocadora.Enums;
using System.ComponentModel.DataAnnotations;

namespace RotaLocadora.Model
{
    public class UsuariosModel
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? DataAniversario { get; set; }
    }
}
