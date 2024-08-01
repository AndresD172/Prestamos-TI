using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadPrestamo
    {
        public int IdPrestamo { get; set; }
        public int IdPrestatario { get; set; }
        public int IdTecnico { get; set; }
        public int IdEstadoCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }
}
