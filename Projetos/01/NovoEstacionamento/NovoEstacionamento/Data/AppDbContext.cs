
using Microsoft.EntityFrameworkCore;
using NovoEstacionamento.Models;

namespace NovoEstacionamento.Data
{
    // Cozinheiro : "DbContext é a classe principal do Entity Framework Core
    // que gerencia a conexão com o banco de dados
    // e é usado para consultar e salvar dados."
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vagaa> Vagas { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Servico> Servicos { get; set; }


    }
}
