using Entidades;
using DAL;

namespace BL
{
    public class BLTécnico
    {
        public static Respuesta RegistrarTécnico(EntidadTécnico técnico)
        {
            DALTécnico daltécnico = new DALTécnico();

            return daltécnico.RegistrarTécnico(técnico);

        }
        public static Respuesta ListarTécnico(string cTexto)
        {
            DALTécnico daltécnico = new DALTécnico();

            return daltécnico.ListarTécnico(cTexto);

        }
        public static Respuesta EliminarTécnico(int IdTécnico)
        {
            DALTécnico daltécnico = new DALTécnico();

            return daltécnico.EliminarTécnico(IdTécnico);

        }
        public static Respuesta ActualizarTécnico(EntidadTécnico técnico)
        {
            DALTécnico daltécnico = new DALTécnico();

            return daltécnico.ActualizarTécnico(técnico);

        }
    }
}