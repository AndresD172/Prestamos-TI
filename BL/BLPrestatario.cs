using Entidades;
using DAL;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BL

{
    public class BLPrestatario
    {
        public static Respuesta RegistrarPrestatario(EntidadPrestatario prestatario)
        {
            DALPrestatario DalPrestatario = new DALPrestatario();

            return DalPrestatario.RegistrarPrestatario(prestatario);

        }
        public static Respuesta ListarPrestatario(string cTexto)
        {
            DALPrestatario DalPrestatario = new DALPrestatario();

            return DalPrestatario.ListarPrestatario(cTexto);

        }
        public static Respuesta EliminarPrestatario(int IdPrestatario)
        {
            DALPrestatario DalPrestatario = new DALPrestatario();

            return DalPrestatario.EliminarPrestatario(IdPrestatario);

        }
        public static Respuesta ActualizarPrestatario(EntidadPrestatario prestatario)
        {
            DALPrestatario DalPrestatario = new DALPrestatario();

            return DalPrestatario.ActualizarPrestatario(prestatario);

        }
    }   
}