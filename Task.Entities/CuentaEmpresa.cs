using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Entities
{
    public class CuentaEmpresa : Cuenta
    {
        public List<Equipo> Equipos { get; set; }
        public required Empresa Empresa { get; set; }

    }
}
