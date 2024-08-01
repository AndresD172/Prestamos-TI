using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadEquipo
    {

        public int IdEquipo { get; set; }
        public int IdCategoria { get; set; }
        public int IdEstadoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NúmeroSerie { get; set; }
        public string Descripción { get; set; }

    }
}
