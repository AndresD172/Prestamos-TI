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

                comando.Parameters.Add("@id_seccion", SqlDbType.Int).Value = prestatario.IdSección ?? (object)DBNull.Value;
                comando.Parameters.Add("@id_departamento", SqlDbType.Int).Value = prestatario.IdDepartamento ?? (object)DBNull.Value;
                comando.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = prestatario.IdEspecialidad;
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = prestatario.Nombre;
                comando.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = prestatario.Apellidos;
                comando.Parameters.Add("@numero_carnet", SqlDbType.NVarChar).Value = prestatario.NúmeroCarnet;
                comando.Parameters.Add("@correo_electronico", SqlDbType.NVarChar).Value = prestatario.CorreoElectrónico;


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
                comando.Parameters.Add("@id", SqlDbType.Int).Value = IdPrestatario;

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
                comando.Parameters.Add("@id_seccion", SqlDbType.Int).Value = prestatario.IdSección;
                comando.Parameters.Add("@id_departamento", SqlDbType.Int).Value = prestatario.IdDepartamento;
                comando.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = prestatario.IdEspecialidad;
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = prestatario.Nombre;
                comando.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = prestatario.Apellidos;
                comando.Parameters.Add("@numero_carnet", SqlDbType.NVarChar).Value = prestatario.NúmeroCarnet;
                comando.Parameters.Add("@correo_electronico", SqlDbType.NVarChar).Value = prestatario.CorreoElectrónico;

                // Se abre la conexion con la BD
                SqlCon.Open();

                // Si la ejecucion del comando es 1 indica que se guardo el dato, sino no
                return comando.ExecuteNonQuery() > 1 ? new Respuesta(0, "Operación exitosa.") : new Respuesta(1, "Error al almacenar los datos.");
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
