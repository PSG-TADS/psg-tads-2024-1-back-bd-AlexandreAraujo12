using System.ComponentModel.DataAnnotations;

namespace API_Veiculos.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
    }
}
