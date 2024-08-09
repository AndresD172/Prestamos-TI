using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BL
{
    public class BLMulta
    {
        public static Respuesta RegistrarMulta(EntidadMulta multa)
        {
            DALMulta dalmulta = new DALMulta();

            return dalmulta.RegistrarMulta(multa);

        }
        public static Respuesta ListarMulta(string cTexto)
        {
            DALMulta dalmulta = new DALMulta();

            return dalMulta.ListarMulta(cTexto);

        }
        public static Respuesta EliminarMulta(int IdMulta)
        {
            DALMulta dalmulta = new DALMulta();

            return dalmulta.EliminarMulta(IdMulta);

        }
        public static Respuesta ActualizarMulta(EntidadMulta multa)
        {
            DALMulta dalmulta = new DALMulta();

            return dalmulta.ActualizarMulta(multa);

        }
    }
}