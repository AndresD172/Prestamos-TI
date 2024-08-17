using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLEstadoEquipo
    {
        public static Respuesta RegistrarEstadoEquipo(EntidadEstadoEquipo estadoequipo)
        {
            DALEstadoEquipo DalEstadoEquipo = new DALEstadoEquipo();

            return DalEstadoEquipo.RegistrarEstadoEquipo(estadoequipo);
        }
        public static Respuesta ListarEstadoEquipo(string cTexto)
        {
            DALEstadoEquipo DalEstadoEquipo = new DALEstadoEquipo();

            return DalEstadoEquipo.ListarEstadoEquipo(cTexto);
        }
        public static Respuesta EliminarEstadoEquipo(int IdEstadoEquipo)
        {
            DALEstadoEquipo DalEstadoEquipo = new DALEstadoEquipo();

            return DalEstadoEquipo.EliminarEstadoEquipo(IdEstadoEquipo);
        }
        public static Respuesta ActualizarEstadoEquipo(EntidadEstadoEquipo estadoequipo)
        {
            DALEstadoEquipo DalEstadoEquipo = new DALEstadoEquipo();

            return DalEstadoEquipo.ActualizarEstadoEquipo(estadoequipo);
        }
    }
}