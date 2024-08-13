using Entidades;
using DAL;

namespace BL
{
    public class BLTécnico
    {
        public static Respuesta RegistrarTécnico(EntidadTécnico técnico)
        {
            DALTécnico DalTecnico = new DALTécnico();

            return DalTecnico.RegistrarTécnico(técnico);

        }
        public static Respuesta ListarTécnico(string cTexto)
        {
            DALTécnico DalTecnico = new DALTécnico();

            return DalTecnico.ListarTécnico(cTexto);

        }
        public static Respuesta EliminarTécnico(int IdTécnico)
        {
            DALTécnico DalTecnico = new DALTécnico();

            return DalTecnico.EliminarTécnico(IdTécnico);

        }
        public static Respuesta ActualizarTécnico(EntidadTécnico técnico)
        {
            DALTécnico DalTecnico = new DALTécnico();

            return DalTecnico.ActualizarTécnico(técnico);

        }
    }
}