using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Entities
{
    public class Cuenta
    {
        public required Administrador Owner { get; set; }
        public List<Tarea>? Tareas { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public TipoCuenta TipoCuenta { get; set; } = TipoCuenta.Personal;
    }
}
