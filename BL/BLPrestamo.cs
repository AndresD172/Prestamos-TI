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
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.RegistrarPrestamo(prestamo);
        }
        public Respuesta ListarPrestamo(string cTexto)
        {
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.ListarPrestamo(cTexto);
        }
        public Respuesta ListarPrestamoEspecifico(int Id)
        {
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.ListarPrestamoEspecifico(Id);
        }
        public Respuesta EliminarPrestamo(int IdPrestamo)
        {
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.EliminarPréstamo(IdPrestamo);
        }
        public Respuesta ActualizarPrestamo(EntidadPréstamo prestamo)
        {
            DALPrestamo DalPrestamo = new DALPrestamo();

            return DalPrestamo.ActualizarPrestamo(prestamo);
        }
    }
}
