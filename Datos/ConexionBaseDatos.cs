using Microsoft.Data.SqlClient;

namespace DAL
{
    public class ConexionBaseDatos
    {
        //Atributos
        private string _baseDatos;
        private string _server;
        private bool _seguridad;
        private static ConexionBaseDatos Conexion = null;

        //Constructor de la BD
        private ConexionBaseDatos()
        {
            //Nombre de la BD
            this._baseDatos = "sistema_prestamos";
            //Nombre Servidor
            this._server = "localhost";
            this._seguridad = true;
        }

        public SqlConnection CrearConexion()
        {

            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = $"Server = {this._server}; Database = {this._baseDatos}; TrustServerCertificate = true;";

                if (_seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
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