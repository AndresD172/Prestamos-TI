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
    public class DALEquipo
    {
        public Respuesta RegistrarEquipo(EntidadEquipo equipo)
        {
            // Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_registrar_equipo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Paramentros
                comando.Parameters.Add("@id_categoría", SqlDbType.Int).Value = equipo.IdCategoría;
                comando.Parameters.Add("@id_estado_equipo", SqlDbType.Int).Value = equipo.IdEstadoEquipo;
                comando.Parameters.Add("@marca", SqlDbType.NVarChar).Value = equipo.Marca;
                comando.Parameters.Add("@modelo", SqlDbType.NVarChar).Value = equipo.Modelo;
                comando.Parameters.Add("@número_serie", SqlDbType.NVarChar).Value = equipo.NúmeroSerie;
                comando.Parameters.Add("@descripción", SqlDbType.NVarChar).Value = equipo.Descripción;

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

        public Respuesta ListarEquipo(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_listar_equipo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Paramentros
                comando.Parameters.Add("@criterio_busqueda", SqlDbType.NVarChar).Value = cTexto;

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

        public Respuesta EliminarEquipo(int IdEquipo)
        {
            // Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_eliminar_equipo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Paramentros
                comando.Parameters.Add("@id", SqlDbType.Int).Value = IdEquipo;

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

        public Respuesta ActualizarEquipo(EntidadEquipo equipo)
        {
            // Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                // Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                // Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_actualizar_equipo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Paramentros
                comando.Parameters.Add("@id", SqlDbType.Int).Value = equipo.IdEquipo;
                comando.Parameters.Add("@id_categoría", SqlDbType.Int).Value = equipo.IdCategoría;
                comando.Parameters.Add("@id_estado_equipo", SqlDbType.Int).Value = equipo.IdEstadoEquipo;
                comando.Parameters.Add("@marca", SqlDbType.NVarChar).Value = equipo.Marca;
                comando.Parameters.Add("@modelo", SqlDbType.NVarChar).Value = equipo.Modelo;
                comando.Parameters.Add("@número_serie", SqlDbType.NVarChar).Value = equipo.NúmeroSerie;
                comando.Parameters.Add("@descripción", SqlDbType.NVarChar).Value = equipo.Descripción;

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
