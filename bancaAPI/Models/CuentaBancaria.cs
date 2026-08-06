
namespace bancaAPI.Models
{
    public class CuentaBancaria
    {
        public int ID {get; set;}
        public string NumeroCuenta {get; set;}= string.Empty;
        public decimal Saldo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

 }
}