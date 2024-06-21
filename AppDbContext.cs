using Microsoft.EntityFrameworkCore;

namespace Senac.T14.WF.Exercicio
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=chamandas.db");
        }
    }
}
