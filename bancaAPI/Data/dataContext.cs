using bancaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace bancaAPI.Data
{
    public class BancaContext : DbContext
    {
        public BancaContext(DbContextOptions<BancaContext> options) : base(options){}
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CuentaBancaria>()
                .HasIndex(c => c.NumeroCuenta)
                .IsUnique();
        }
    }
}
