using EsteticaSalonWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EsteticaSalonWeb.Data
{
    // Heredamos de DbContext, que es la clase base de Entity Framework Core
    public class ApplicationDbContext : DbContext
    {
        // El constructor recibe las opciones de configuración (como la cadena de conexión) 
        // y se las pasa a la clase padre (base)
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Definimos los DbSets. Cada DbSet se convertirá en una tabla física en SQL.
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<DetalleServicio> DetallesServicios { get; set; }

        // Este método nos permite configurar detalles más específicos del modelo de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ejemplo: Configurar precisión específica para campos monetarios si fuera necesario
            modelBuilder.Entity<Cita>()
                .Property(c => c.Total)
                .HasPrecision(18, 2);

            modelBuilder.Entity<DetalleServicio>()
                .Property(d => d.Precio)
                .HasPrecision(18, 2);
        }
    }
}