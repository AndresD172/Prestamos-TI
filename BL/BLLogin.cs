using Entidades;
using DAL;
using Datos;

namespace BL
{
    public class BLLogin
    {
        public static Respuesta RegistrarLogin(EntidadLogin login)
        {

            DALLogin DalLogin = new DALLogin();

            return DalLogin.RegistrarLogin(login);

        }

        public static Respuesta VerificarLogin(EntidadLogin login)
        {
            DALLogin DalLogin = new DALLogin();

            return DalLogin.VerificarLogin(login);
        }
    }
}
