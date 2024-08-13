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
        public static Respuesta RegistrarTipoMulta(EntidadMulta multa)
        {
            DALMulta DalTipoMulta = new DALMulta();

            return DalTipoMulta.RegistrarMulta(multa);

        }
        public static Respuesta ListarTipoMulta(string cTexto)
        {
            DALMulta DalTipoMulta = new DALMulta();

            return DalTipoMulta.ListarMulta(cTexto);

        }
        public static Respuesta EliminarMulta(int IdMulta)
        {
            DALMulta DalTipoMulta = new DALMulta();

            return DalTipoMulta.EliminarMulta(IdMulta);

        }
        public static Respuesta ActualizarMulta(EntidadMulta multa)
        {
            DALMulta DalTipoMulta = new DALMulta();

            return DalTipoMulta.ActualizarMulta(multa);

        }
    }
}