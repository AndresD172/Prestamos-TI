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
        public Respuesta RegistrarPrestamo(EntidadPréstamo prestamo)
        {
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.RegistrarPrestamo(prestamo);
        }
        public Respuesta ListarPrestamo(string cTexto)
        {
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.ListarPrestamo(cTexto);
        }
        public Respuesta ListarPrestamoEspecifico(int Id)
        {
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.ListarPrestamoEspecifico(Id);
        }
        public Respuesta EliminarPrestamo(int IdPrestamo)
        {
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.EliminarPréstamo(IdPrestamo);
        }
        public Respuesta ActualizarPrestamo(EntidadPréstamo prestamo)
        {
            DALPrestamo dalprestamo = new DALPrestamo();

            return dalprestamo.ActualizarPrestamo(prestamo);
        }
    }
}
