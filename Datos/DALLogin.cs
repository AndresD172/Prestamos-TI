using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class DALLogin
    {
        public Respuesta RegistrarLogin(EntidadLogin login)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_registrar_login", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = login.Usuario;
                comando.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = login.Contraseña;

                SqlCon.Open();

                return comando.ExecuteNonQuery() == 1 ? new Respuesta(0, "Operación exitosa.") : new Respuesta(1, "Error al almacenar los datos.");
            }
            catch (Exception ex)
            {
                return new Respuesta(ex.HResult, ex.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public Respuesta VerificarLogin(EntidadLogin login)
        {
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_verificar_login", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = login.Usuario;
                comando.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = login.Contraseña;

                SqlCon.Open();

                return comando.ExecuteNonQuery() == 1 ? new Respuesta(0, "Operación exitosa.") : new Respuesta(1, "Error al almacenar los datos.");
            }
            catch (Exception ex)
            {
                return new Respuesta(ex.HResult, ex.Message);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }
    }
}
