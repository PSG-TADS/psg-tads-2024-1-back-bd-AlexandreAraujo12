using System.ComponentModel.DataAnnotations;

namespace API_Veiculos.Models
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Status { get; set; }
        public ICollection<Veiculo>? Veiculos { get; set; }

    }
}
