using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ETPrestatario : ETPersona 
    {
        public int IdPrestatario { get; set; }
        public int? IdSección { get; set; }
        public int? IdDepartamento { get; set; }
        public int IdEspecialidad { get; set; }
    }
}
