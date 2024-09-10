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
    public class DALTécnico
    {
        public Respuesta RegistrarTécnico(EntidadTécnico técnico)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_registrar_tecnico", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = técnico.Nombre;
                comando.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = técnico.Apellidos;
                comando.Parameters.Add("@numero_carnet", SqlDbType.NVarChar).Value = técnico.NúmeroCarnet;
                comando.Parameters.Add("@correo_electrónico", SqlDbType.NVarChar).Value = técnico.CorreoElectrónico;
                comando.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = técnico.Contraseña;

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

        public Respuesta ListarTécnico(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_listar_tecnicos", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@criterio_busqueda", SqlDbType.NVarChar).Value = cTexto;

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

        public Respuesta EliminarTécnico(int IdTécnico)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_eliminar_tecnico", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@id", SqlDbType.Int).Value = IdTécnico;

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

        public Respuesta ActualizarTécnico(EntidadTécnico técnico)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_actualizar_técnico", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", SqlDbType.Int).Value = técnico.IdTécnico;
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = técnico.Nombre;
                comando.Parameters.Add("@apellidos", SqlDbType.NVarChar).Value = técnico.Apellidos;
                comando.Parameters.Add("@numero_carnet", SqlDbType.NVarChar).Value = técnico.NúmeroCarnet;
                comando.Parameters.Add("@correo_electrónico", SqlDbType.NVarChar).Value = técnico.CorreoElectrónico;

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
