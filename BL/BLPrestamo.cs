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
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.RegistrarPrestamo(prestamo);
        }
        public static Respuesta ListarPrestamo(string cTexto)
        {
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.ListarPrestamo(cTexto);
        }
        public static Respuesta ListarPrestamoEspecifico(int Id)
        {
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.ListarPrestamoEspecifico(Id);
        }
        public static Respuesta EliminarPrestamo(int IdPrestamo)
        {
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.EliminarPréstamo(IdPrestamo);
        }
        public static Respuesta ActualizarPrestamo(EntidadPréstamo prestamo)
        {
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.ActualizarPrestamo(prestamo);
        }
    }
}
