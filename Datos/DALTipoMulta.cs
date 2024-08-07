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
    public class DALTipoMulta
    {
        public Respuesta RegistrarTipoMulta(EntidadTipoMulta tipoMulta)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_registrar_tipo_multa", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = tipoMulta.Nombre;
                comando.Parameters.Add("@descripción", SqlDbType.NVarChar).Value = tipoMulta.Descripción;

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

        public Respuesta ListarTipoMulta(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_listar_tipo_multas", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@cTexto", SqlDbType.NVarChar).Value = cTexto;

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

        public Respuesta EliminarTipoMulta(int IdTipoMulta)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_eliminar_tipo_multa", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@IdTipoMulta", SqlDbType.Int).Value = IdTipoMulta;

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

        public Respuesta ActualizarTipoMulta(EntidadTipoMulta tipoMulta)
        {
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("usp_actualizar_tipo_multa", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@id", SqlDbType.Int).Value = tipoMulta.IdTipoMulta;
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = tipoMulta.Nombre;
                comando.Parameters.Add("@descripción", SqlDbType.NVarChar).Value = tipoMulta.Descripción;

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
