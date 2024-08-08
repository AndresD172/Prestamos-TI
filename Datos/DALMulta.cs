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
    public class DALMulta
    {
        public Respuesta RegistrarMulta(EntidadMulta multa)
        {
            //Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                //Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_registrar_multa", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Paramentros
                //metodo get
                comando.Parameters.Add("@id_tipo_multa", SqlDbType.Int).Value = multa.IdTipoMulta;
                comando.Parameters.Add("@id_prestatario", SqlDbType.Int).Value = multa.IdPrestatario;
                comando.Parameters.Add("@id_tecnico", SqlDbType.Int).Value = multa.IdTécnico;
                comando.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = multa.Descripción;

                //Se abre la conexion con la BD
                SqlCon.Open();

                //Si la ejecucion del comando es 1 indica que se guardo el dato, sino no.
                return comando.ExecuteNonQuery() == 1 ? new Respuesta(0, "Operación exitosa.") : new Respuesta(1, "Error al almacenar los datos.");


            }
            catch (Exception ex)
            {
                // Establece el código de error dentro del mensaje como ex.HResult y ex.Message como el mensaje de error.
                return new Respuesta(ex.HResult, ex.Message);
            }
            finally
            {
                //Cierra la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }


        public Respuesta ListarMulta(string cTexto)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                //Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                //Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_listar_multa", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Paramentros
                comando.Parameters.Add("@cTexto", SqlDbType.NVarChar).Value = cTexto;

                //Se abre la conexion con la BD
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
                //Cierra la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }


        public Respuesta EliminarMulta(int IdMulta)
        {

            //Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                //Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                //Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_eliminar_multa", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Paramentros
                comando.Parameters.Add("@id", SqlDbType.Int).Value = IdMulta;

                //Se abre la conexion con la BD
                SqlCon.Open();

                return comando.ExecuteNonQuery() == 1 ? new Respuesta(0, "Operación exitosa.") : new Respuesta(1, "Error al almacenar los datos."

            }
            catch (Exception ex)
            {
                // Establece el código de error dentro del mensaje como ex.HResult y ex.Message como el mensaje de error.
                return new Respuesta(ex.HResult, ex.Message);
            }
            finally
            {
                //Cierra la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }
        public Respuesta ActualizarMulta(EntidadMulta multa)
        {

            //Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                //Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_actualizar_multa", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Paramentros
                //mEntidadodo gEntidad
                comando.Parameters.Add("@id", SqlDbType.Int).Value = multa.IdMulta;
                comando.Parameters.Add("@id_tipo_multa", SqlDbType.Int).Value = multa.IdTipoMulta;
                comando.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = multa.Descripción;
                //Se abre la conexion con la BD
                SqlCon.Open();

                //Si la ejecucion del comando es 1 indica que se guardo el dato, sino no
                return comando.ExecuteNonQuery() == 1 ? new Respuesta(0, "Operación exitosa.") : new Respuesta(1, "Error al almacenar los datos."


            }
            catch (Exception ex)
            {
                // Establece el código de error dentro del mensaje como ex.HResult y ex.Message como el mensaje de error.
                return new Respuesta(ex.HResult, ex.Message);
            }
            finally
            {
                //Cierra la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
