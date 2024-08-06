using Microsoft.Data.SqlClient;

namespace DAL
{
    public class ConexionBaseDatos
    {
        //Atributos
        private string _BaseDatos;
        private string _Server;
        private bool _Seguridad;
        private static ConexionBaseDatos Conexion = null;

        //Constructor de la BD
        private ConexionBaseDatos()
        {
            //Nombre de la BD
            this._BaseDatos = "Sistema_Préstamos";
            //Nombre Servidor
            this._Server = "localhost";
            this._Seguridad = true;
        }

        public SqlConnection CrearConexion()
        {

            SqlConnection cadena = new SqlConnection();

            try
            {

                cadena.ConnectionString = "Server =" + this._Server + ";Database=" + this._BaseDatos + ";";

                if (_Seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security=SSPI";
                }
                else
                {
                    // cadena.ConnectionString = cadena.ConnectionString +"User Id="+this. Usuario 
                    //Aca se completaria en caso de ser con usuario y contrasena de SQL
                }

            }

            catch (Exception ex)
            {

                cadena = null;
                throw ex;

            }

            return cadena;

        }


        public static ConexionBaseDatos GetInstancia()
        {
            if (Conexion == null)
            {
                Conexion = new ConexionBaseDatos();
            }
            return Conexion;
        }
    }
}