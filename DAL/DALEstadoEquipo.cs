using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DALEstadoEquipo
    {
        public string GuardarEstadoEquipo(ETEstadoEquipo estadoEquipo)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexión a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_registrar_estados_equipos", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros
      
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = estadoEquipo.Nombre;

                // Se abre la conexión con la BD
                SqlCon.Open();

                // Si la ejecución del comando es >= 1 indica que se guardó el dato, sino no
                Respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se logró registrar el dato";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                // Cierra la conexión con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }
        public DataTable ListadoEstadoEquipo(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexión a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_listado_estados_equipos", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros
                comando.Parameters.Add("@cTexto", SqlDbType.NVarChar).Value = cTexto;

                // Se abre la conexión con la BD
                SqlCon.Open();

                // Ejecutar el comando y cargar el resultado en la tabla
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Cierra la conexión con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public string EliminarEstadoEquipo(int IdEstadoEquipo)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexión a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_eliminar_estados_equipos", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros
                comando.Parameters.Add("@id", SqlDbType.Int).Value = IdEstadoEquipo;

                // Se abre la conexión con la BD
                SqlCon.Open();

                // Si la ejecución del comando es 1 indica que se eliminó el dato, sino no
                Respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se logró eliminar el dato";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                // Cierra la conexión con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }
        public string ActualizarEstadoEquipo(ETEstadoEquipo estadoEquipo)
        {
            string Respuesta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexión a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("USP_Actualizar_EstadoEquipo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = estadoEquipo.IdEstadoEquipo;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = estadoEquipo.Nombre;

                // Se abre la conexión con la BD
                SqlCon.Open();

                // Si la ejecución del comando es >= 1 indica que se actualizó el dato, sino no
                Respuesta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se logró actualizar el dato";
            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally
            {
                // Cierra la conexión con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }






















    }
}
