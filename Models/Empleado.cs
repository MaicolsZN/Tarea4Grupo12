using System;
using System.Collections.Generic;

#nullable disable

namespace PracticaEntityGrupo12.Models
{
    public partial class Empleado
    {
        public int CodigoEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public decimal? SalarioEmpleado { get; set; }
        public DateTime? FechaIngresoEmpleado { get; set; }
    }
}
