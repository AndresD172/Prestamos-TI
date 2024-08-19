using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLSeccion
    {
        public static Respuesta RegistrarSeccion(EntidadSección seccion)
        {
            DALSeccion DalSeccion = new DALSeccion();

            return DalSeccion.RegistrarSeccion(seccion);
        }
        public static Respuesta ListarSeccion(string cTexto)
        {
            DALSeccion DalSeccion = new DALSeccion();

            return DalSeccion.ListarSeccion(cTexto);
        }
        public static Respuesta EliminarSeccion(int IdSeccion)
        {
            DALSeccion DalSeccion = new DALSeccion();

            return DalSeccion.EliminarSeccion(IdSeccion);
        }
        public static Respuesta ActualizarSeccion(EntidadSección seccion)
        {
            DALSeccion DalSeccion = new DALSeccion();

            return DalSeccion.RegistrarSeccion(seccion);
        }
    }
}
