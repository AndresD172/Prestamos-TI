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
            DALPrestatario dalprestatario = new DALPrestatario();

            return dalprestatario.RegistrarPrestatario(prestatario);

        }
        public static Respuesta ListarPrestatario(string cTexto)
        {
            DALPrestatario dalprestatario = new DALPrestatario();

            return dalprestatario.ListarPrestatario(cTexto);

        }
        public static Respuesta EliminarPrestatario(int IdPrestatario)
        {
            DALPrestatario dalprestatario = new DALPrestatario();

            return dalprestatario.EliminarPrestatario(IdPrestatario);

        }
        public static Respuesta ActualizarPrestatario(EntidadPrestatario prestatario)
        {
            DALPrestatario dalprestatario = new DALPrestatario();

            return dalprestatario.ActualizarPrestatario(prestatario);

        }
    }
}