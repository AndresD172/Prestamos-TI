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
            DALEspecialidad DalEspecialidad = new DALEspecialidad();

            return DalEspecialidad.RegistrarEspecialidad(especialidad);
        }
        public static Respuesta ListarEspecialidad(string cTexto)
        {
            DALEspecialidad DalEspecialidad = new DALEspecialidad();

            return DalEspecialidad.ListarEspecialidad(cTexto);
        }
        public static Respuesta EliminarEspecialidad(int IdEspecialidad)
        {
            DALEspecialidad DalEspecialidad = new DALEspecialidad();

            return DalEspecialidad.EliminarEspecialidad(IdEspecialidad);
        }
        public static Respuesta ActualizarEspecialidad(EntidadEspecialidad especialidad)
        {
            DALEspecialidad DalEspecialidad = new DALEspecialidad();

            return DalEspecialidad.ActualizarEspecialidad(especialidad);
        }
    }
}
