using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLEquipo
    {
        public static Respuesta RegistrarEquipo(EntidadEquipo equipo)
        {
            DALEquipo DalEquipo = new DALEquipo();

            return DalEquipo.RegistrarEquipo(equipo);
        }
        public static Respuesta ListarEquipo(string cTexto)
        {
            DALEquipo DalEquipo = new DALEquipo();

            return DalEquipo.ListarEquipo(cTexto);
        }
        public static Respuesta EliminarEquipo(int IdEquipo)
        {
            DALEquipo DalEquipo = new DALEquipo();

            return DalEquipo.EliminarEquipo(IdEquipo);
        }
        public static Respuesta ActualizarEquipo(EntidadEquipo equipo)
        {
            DALEquipo DalEquipo = new DALEquipo();

            return DalEquipo.ActualizarEquipo(equipo);
        }
    }
}
