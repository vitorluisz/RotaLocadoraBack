using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RotaLocadora.Model
{
    public class HistoryActivitiesModel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Carro")]
        public int IdCarro { get; set; }
        public string? TipoDeRegistro { get; set; }
        public string? Placa { get; set; }
        public DateTime DataDaEdicao { get; set; } = DateTime.Now;
    }
}
