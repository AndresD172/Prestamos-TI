using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace DAL
{
    public class DALPrestatario
    {
        public Respuesta RegistrarPrestatario(EntidadPrestatario prestatario)
        {
            // Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_registrar_prestatario", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Paramentros
               
                comando.Parameters.Add("@IdSección", SqlDbType.Int).Value = prestatario.IdSección ?? (object)DBNull.Value;
                comando.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = prestatario.IdDepartamento ?? (object)DBNull.Value;
                comando.Parameters.Add("@IdEspecialidad", SqlDbType.Int).Value = prestatario.IdEspecialidad;

                // Se abre la conexion con la BD
                SqlCon.Open();

                // Si la ejecucion del comando es 1 indica que se guardo el dato, sino no.
                return comando.ExecuteNonQuery() == 1 ? new Respuesta(0, "Operación exitosa.") : new Respuesta(1, "Error al almacenar los datos.");
            }
            catch (Exception ex)
            {
                // Establece el código de error dentro del mensaje como ex.HResult y ex.Message como el mensaje de error.
                return new Respuesta(ex.HResult, ex.Message);
            }
            finally
            {
                // Cierra la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public Respuesta ListarPrestatario(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_listar_prestatarios", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Paramentros
                comando.Parameters.Add("@cTexto", SqlDbType.NVarChar).Value = cTexto;

                // Se abre la conexion con la BD
                SqlCon.Open();

                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);

                return new Respuesta(0, Tabla);
            }
            catch (Exception ex)
            {
                // Establece el código de error dentro del mensaje como ex.HResult y ex.Message como el mensaje de error.
                return new Respuesta(ex.HResult, ex.Message);
            }
            finally
            {
                // Cierra la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public Respuesta EliminarPrestatario(int IdPrestatario)
        {
            // Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_eliminar_prestatario", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Paramentros
                comando.Parameters.Add("@IdPrestatario", SqlDbType.Int).Value = IdPrestatario;

                // Se abre la conexion con la BD
                SqlCon.Open();

                return comando.ExecuteNonQuery() == 1 ? new Respuesta(0, "Operación exitosa.") : new Respuesta(1, "Error al almacenar los datos.");
            }
            catch (Exception ex)
            {
                // Establece el código de error dentro del mensaje como ex.HResult y ex.Message como el mensaje de error.
                return new Respuesta(ex.HResult, ex.Message);
            }
            finally
            {
                // Cierra la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public Respuesta ActualizarPrestatario(EntidadPrestatario prestatario)
        {
            // Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_actualizar_prestatario", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Paramentros
                comando.Parameters.Add("@id", SqlDbType.Int).Value = prestatario.IdPrestatario;
                comando.Parameters.Add("@IdSección", SqlDbType.Int).Value = prestatario.IdSección ?? (object)DBNull.Value;
                comando.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = prestatario.IdDepartamento ?? (object)DBNull.Value;
                comando.Parameters.Add("@IdEspecialidad", SqlDbType.Int).Value = prestatario.IdEspecialidad;

                // Se abre la conexion con la BD
                SqlCon.Open();

                // Si la ejecucion del comando es 1 indica que se guardo el dato, sino no
                return comando.ExecuteNonQuery() == 1 ? new Respuesta(0, "Operación exitosa.") : new Respuesta(1, "Error al almacenar los datos.");
            }
            catch (Exception ex)
            {
                // Establece el código de error dentro del mensaje como ex.HResult y ex.Message como el mensaje de error.
                return new Respuesta(ex.HResult, ex.Message);
            }
            finally
            {
                // Cierra la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
