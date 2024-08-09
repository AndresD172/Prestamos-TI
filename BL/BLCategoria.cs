using Entidades;
using DAL;
namespace BL
{
    public class BLCategoria
    {
        public static Respuesta RegistrarCategoria(EntidadCategoría categoria)
        {
            DALCategoria dalcategoria = new DALCategoria();

            return dalcategoria.RegistrarCategoria(categoria);

        }
        public static Respuesta ListarCategoria(string cTexto)
        {
            DALCategoria dalcategoria = new DALCategoria();

            return dalcategoria.ListarCategoria(cTexto);

        }
        public static Respuesta EliminarCategoria(int IdCategoria)
        {
            DALCategoria dalcategoria = new DALCategoria();

            return dalcategoria.EliminarCategoria(IdCategoria);

        }
        public static Respuesta ActualizarCategoria(EntidadCategoría categoria)
        {
            DALCategoria dalcategoria = new DALCategoria();

            return dalcategoria.ActualizarCategoria(categoria);

        }
    }
}
