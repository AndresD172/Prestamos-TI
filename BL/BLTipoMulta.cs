using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BL
{
    public class BLTipoMulta
    {
        public static Respuesta RegistrarTipoMulta(EntidadTipoMulta multa)
        {
            DALTipoMulta DalTipoMulta = new DALTipoMulta();

            return DalTipoMulta.RegistrarTipoMulta(multa);

        }
        public static Respuesta ListarTipoMulta(string cTexto)
        {
            DALTipoMulta DalTipoMulta = new DALTipoMulta();

            return DalTipoMulta.ListarTipoMulta(cTexto);

        }
        public static Respuesta EliminarMulta(int IdMulta)
        {
            DALTipoMulta DalTipoMulta = new DALTipoMulta();

            return DalTipoMulta.EliminarTipoMulta(IdMulta);

        }
        public static Respuesta ActualizarMulta(EntidadTipoMulta multa)
        {
            DALTipoMulta DalTipoMulta = new DALTipoMulta();

            return DalTipoMulta.ActualizarTipoMulta(multa);

        }
    }
}