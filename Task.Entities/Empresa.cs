using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Entities
{
    public class Empresa : Cuenta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Direccion { get; set; }
        public required string RUT { get; set; }
        public string? RazonSocial { get; set; }

    }
}
