using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLPrestamo
    {
        public static Respuesta RegistrarPrestamo(EntidadPréstamo prestamo)
        {
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.RegistrarPrestamo(prestamo);
        }
        public static Respuesta ListarPrestamo(string cTexto)
        {
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.ListarPrestamo(cTexto);
        }
        public static Respuesta ListarPrestamoEspecifico(int Id)
        {
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.ListarPrestamoEspecifico(Id);
        }
        public static Respuesta EliminarPrestamo(int IdPrestamo)
        {
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.EliminarPréstamo(IdPrestamo);
        }
        public static Respuesta ActualizarPrestamo(EntidadPréstamo prestamo)
        {
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.ActualizarPrestamo(prestamo);
        }
    }
}
