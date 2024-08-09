using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLMulta
    {
        public Respuesta RegistrarMulta(EntidadMulta multa)
        {
            DALMulta dalmulta = new DALMulta();

            return dalmulta.RegistrarMulta(multa);
        }
        public Respuesta ListarMulta(string cTexto)
        {
            DALMulta dalmulta = new DALMulta();

            return dalmulta.ListarMulta(cTexto);
        }
        public Respuesta EliminarMulta(int IdMulta)
        {
            DALMulta dalmulta = new DALMulta();

            return dalmulta.EliminarMulta(IdMulta);
        }
        public Respuesta ActualizarMulta(EntidadMulta multa)
        {
            DALMulta dalmulta = new DALMulta();

            return dalmulta.ActualizarMulta(multa);
        }
    }
}
