using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLEstadoPrestamo
    {
        public Respuesta RegistrarEstadoPrestamo(EntidadEstadoPréstamo estadoprestamo)
        {
            DALEstadoPrestamo DalEstadoPrestamo = new DALEstadoPrestamo();

            return DalEstadoPrestamo.RegistrarEstadoPrestamo(estadoprestamo);
        }
        public Respuesta ListarEstadoPrestamo(string cTexto)
        {
            DALEstadoPrestamo DalEstadoPrestamo = new DALEstadoPrestamo();

            return DalEstadoPrestamo.ListarEstadoPrestamo(cTexto);
        }
        public Respuesta EliminarEstadoPrestamo(int IdEstadoPrestamo)
        {
            DALEstadoPrestamo DalEstadoPrestamo = new DALEstadoPrestamo();

            return DalEstadoPrestamo.EliminarEstadoPrestamo(IdEstadoPrestamo);
        }
        public Respuesta ActualizarEstadoPrestamo(EntidadEstadoPréstamo estadoprestamo)
        {
            DALEstadoPrestamo DalEstadoPrestamo = new DALEstadoPrestamo();

            return DalEstadoPrestamo.ActualizarEstadoPrestamo(estadoprestamo);
        }
    }
}