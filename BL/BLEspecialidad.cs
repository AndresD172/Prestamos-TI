using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLEspecialidad
    {
        public static  Respuesta RegistrarEspecialidad(EntidadEspecialidad especialidad) 
        {
            DALEspecialidad dalespecialidad = new DALEspecialidad();

            return dalespecialidad.RegistrarEspecialidad(especialidad);
        }
        public static Respuesta ListarEspecialidad(string cTexto)
        {
            DALEspecialidad dalespecialidad = new DALEspecialidad();

            return dalespecialidad.ListarEspecialidad(cTexto);
        }
        public static Respuesta EliminarEspecialidad(int IdEspecialidad)
        {
            DALEspecialidad dalespecialidad = new DALEspecialidad();

            return dalespecialidad.EliminarEspecialidad(IdEspecialidad);
        }
        public static Respuesta ActualizarEspecialidad(EntidadEspecialidad especialidad)
        {
            DALEspecialidad dalespecialidad = new DALEspecialidad();

            return dalespecialidad.ActualizarEspecialidad(especialidad);
        }
    }
}
