using Microsoft.EntityFrameworkCore;


namespace API_Veiculos.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Veiculos;Trusted_Connection=True;TrustServerCertificate=true;");
        }
    }
}
