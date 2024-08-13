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
        public Respuesta RegistrarSeccion(EntidadSección seccion)
        {
            DALSeccion DalSeccion = new DALSeccion();

            return DalSeccion.RegistrarSeccion(seccion);
        }
        public Respuesta ListarSeccion(string cTexto)
        {
            DALSeccion DalSeccion = new DALSeccion();

            return DalSeccion.ListarSeccion(cTexto);
        }
        public Respuesta EliminarSeccion(int IdSeccion)
        {
            DALSeccion DalSeccion = new DALSeccion();

            return DalSeccion.EliminarSeccion(IdSeccion);
        }
        public Respuesta ActualizarSeccion(EntidadSección seccion)
        {
            DALSeccion DalSeccion = new DALSeccion();

            return DalSeccion.RegistrarSeccion(seccion);
        }
    }
}
