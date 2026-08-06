using System;

namespace bancaAPI.Models
{
    public class Transaccion
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty; 
        public decimal Monto { get; set; }
        public decimal SaldoResultante { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;

        public int CuentaBancariaId { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; } = null!;
    }
}