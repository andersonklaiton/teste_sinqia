using Microsoft.EntityFrameworkCore;
using PontosTuristicos.Models;

namespace PontosTuristicos.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pontos> Ponto { get; set; }
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}