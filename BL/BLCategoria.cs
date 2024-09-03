using Entidades;
using DAL;
namespace BL
{
    public class BLCategoria
    {
        public static Respuesta RegistrarCategoria(EntidadCategoría categoria)
        {
            DALCategoria DalCategoria = new DALCategoria();

            return DalCategoria.RegistrarCategoria(categoria);

        }
        public static Respuesta ListarCategoria(string cTexto)
        {
            DALCategoria DalCategoria = new DALCategoria();

            return DalCategoria.ListarCategoria(cTexto);

        }
        public static Respuesta EliminarCategoria(int IdCategoria)
        {
            DALCategoria DalCategoria = new DALCategoria();

            return DalCategoria.EliminarCategoria(IdCategoria);

        }
        public static Respuesta ActualizarCategoria(EntidadCategoría categoria)
        {
            DALCategoria DalCategoria = new DALCategoria();

            return DalCategoria.ActualizarCategoria(categoria);

        }
    }
}
