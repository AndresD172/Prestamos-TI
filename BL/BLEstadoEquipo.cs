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
        public Respuesta RegistrarEstadoEquipo(EntidadEstadoEquipo estadoequipo)
        {
            DALEstadoEquipo DalEstadoEquipo = new DALEstadoEquipo();

            return DalEstadoEquipo.RegistrarEstadoEquipo(estadoequipo);
        }
        public Respuesta ListarEstadoEquipo(string cTexto)
        {
            DALEstadoEquipo DalEstadoEquipo = new DALEstadoEquipo();

            return DalEstadoEquipo.ListarEstadoEquipo(cTexto);
        }
        public Respuesta EliminarEstadoEquipo(int IdEstadoEquipo)
        {
            DALEstadoEquipo DalEstadoEquipo = new DALEstadoEquipo();

            return DalEstadoEquipo.EliminarEstadoEquipo(IdEstadoEquipo);
        }
        public Respuesta ActualizarEstadoEquipo(EntidadEstadoEquipo estadoequipo)
        {
            DALEstadoEquipo DalEstadoEquipo = new DALEstadoEquipo();

            return DalEstadoEquipo.ActualizarEstadoEquipo(estadoequipo);
        }
    }
}