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
            DALMulta DalMulta = new DALMulta();

            return DalMulta.RegistrarMulta(multa);
        }
        public Respuesta ListarMulta(string cTexto)
        {
            DALMulta DalMulta = new DALMulta();

            return DalMulta.ListarMulta(cTexto);
        }
        public Respuesta EliminarMulta(int IdMulta)
        {
            DALMulta DalMulta = new DALMulta();

            return DalMulta.EliminarMulta(IdMulta);
        }
        public Respuesta ActualizarMulta(EntidadMulta multa)
        {
            DALMulta DalMulta = new DALMulta();

            return DalMulta.ActualizarMulta(multa);
        }
    }
}
