using System;

namespace bancaAPI.Models
{
    public class Cliente
    {
        public int ID {get; set;}
        public string PrimerNombre {get; set;}= string.Empty;
        public string SegundoNombre {get; set;}= string.Empty;
        public string PrimerApellido {get; set;}= string.Empty;
        public string SegundoApellido {get; set;}= string.Empty;
        public DateTime FechaNacimiento {get; set;}
        public string Sexo {get; set;}= string.Empty;
        public decimal Ingresos {get; set;}

 }
}