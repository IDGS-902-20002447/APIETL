using Microsoft.EntityFrameworkCore;
using PROYECTOAPI.Models;

namespace PROYECTOAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<mayor_vendido_producto> mayor_vendido_producto { get; set; }

        public DbSet<menor_vendido_producto> menor_vendido_producto { get; set; }

        public DbSet<valores_calculados> valores_calculados { get; set; }

        public DbSet<ventas_mensuales> ventas_mensuales { get; set; }
    }
}
