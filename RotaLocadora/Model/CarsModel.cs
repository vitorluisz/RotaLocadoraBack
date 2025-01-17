using System.ComponentModel.DataAnnotations;
using RotaLocadora.Enums;

namespace RotaLocadora.Model
{
    public class CarsModel
    {
        [Key]
        public int Id { get; set; }
        public CarsEnum Marca { get; set; }
        public string? Placa { get; set; }
        public int Star { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public bool ZeroKm { get; set; }
        public int Ano { get; set; }
        public CoresEnum Cor { get; set; }
        public string? Modelo { get; set; }
        public PropositoEnum Proposito { get; set; }
    }
}
