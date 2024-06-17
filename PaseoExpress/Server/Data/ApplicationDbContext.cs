using Microsoft.EntityFrameworkCore;
using PaseoExpress.Shared.Data;

namespace PaseoExpress.Server.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<ObtenerVehiculosSinExistenciaHoy>()
                .HasNoKey();
        }

        public DbSet<ObtenerVehiculosSinExistenciaHoy> obtenerVehiculosSinExistenciaHoys { get; set; }
    }
}
