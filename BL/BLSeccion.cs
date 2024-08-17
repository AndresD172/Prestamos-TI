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
            DALSeccion dalseccion = new DALSeccion();

            return dalseccion.RegistrarSeccion(seccion);
        }
        public static Respuesta ListarSeccion(string cTexto)
        {
            DALSeccion dalseccion = new DALSeccion();

            return dalseccion.ListarSeccion(cTexto);
        }
        public static Respuesta EliminarSeccion(int IdSeccion)
        {
            DALSeccion dalseccion = new DALSeccion();

            return dalseccion.EliminarSeccion(IdSeccion);
        }
        public static Respuesta ActualizarSeccion(EntidadSección seccion)
        {
            DALSeccion dalseccion = new DALSeccion();

            return dalseccion.RegistrarSeccion(seccion);
        }
    }
}
