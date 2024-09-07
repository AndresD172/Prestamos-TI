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
    public class DALEstadoEquipo
    {
        public Respuesta RegistrarEstadoEquipo(EntidadEstadoEquipo estadoEquipo)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_registrar_estado_equipo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = estadoEquipo.Nombre;

                // Abrir conexión y ejecutar comando
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

        public Respuesta ListarEstadoEquipo(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_listar_estados_equipo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros
                comando.Parameters.Add("@criterio_busqueda", SqlDbType.NVarChar).Value = cTexto;

                // Abrir conexión y ejecutar comando
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);

                return new Respuesta(0, Tabla);
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

        public Respuesta EliminarEstadoEquipo(int IdEstadoEquipo)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_eliminar_estado_equipo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros
                comando.Parameters.Add("@id", SqlDbType.Int).Value = IdEstadoEquipo;

                // Abrir conexión y ejecutar comando
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

        public Respuesta ActualizarEstadoEquipo(EntidadEstadoEquipo estadoEquipo)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_actualizar_estado_equipo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros
                comando.Parameters.Add("@id", SqlDbType.Int).Value = estadoEquipo.IdEstadoEquipo;
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = estadoEquipo.Nombre;

                // Abrir conexión y ejecutar comando
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

