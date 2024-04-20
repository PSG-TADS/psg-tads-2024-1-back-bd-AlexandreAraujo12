using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Veiculos.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public int VeiculoId { get; set; }
        [ForeignKey("VeiculoId")]
        public Cliente Cliente { get; set; }
        public Veiculo Veiculo { get; set; }
    }

}
