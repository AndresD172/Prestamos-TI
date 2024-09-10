﻿using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class DALSeccion
    {
        public Respuesta RegistrarSeccion(EntidadSección seccion)
        {
            //Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                //Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_registrar_seccion", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Paramentros
                //metodo get
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = seccion.Nombre;

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


        public Respuesta ListarSeccion(string cTexto)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                //Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                //Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_listar_secciones", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Paramentros
                comando.Parameters.Add("@criterio_busqueda", SqlDbType.NVarChar).Value = cTexto;

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


        public Respuesta EliminarSeccion(int IdSeccion)
        {

            //Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {

                //Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                //Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_eliminar_seccion", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Paramentros
                comando.Parameters.Add("@id", SqlDbType.Int).Value = IdSeccion;

                //Se abre la conexion con la BD
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
                //Cierra la conexion con la BD
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }
        public Respuesta ActualizarSeccion(EntidadSección seccion)
        {

            //Conexion de la BD
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Se establece la conexion a la BD
                SqlCon = ConexionBaseDatos.GetInstancia().CrearConexion();

                //Se indica el SP a usar y el tipo de comando
                SqlCommand comando = new SqlCommand("usp_actualizar_seccion", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //Paramentros

                comando.Parameters.Add("@id", SqlDbType.Int).Value = seccion.IdSección;
                comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = seccion.Nombre;

                //Se abre la conexion con la BD
                SqlCon.Open();

                //Si la ejecucion del comando es 1 indica que se guardo el dato, sino no
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
    }
}
