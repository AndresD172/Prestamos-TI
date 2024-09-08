namespace Entidades;

public class Respuesta
{
    public int CódigoEstado { get; set; }
    public dynamic Contenido { get; set; }
   

    public Respuesta() { }
    public Respuesta(int códigoEstado, dynamic contenido)
    {
        this.CódigoEstado = códigoEstado;
        this.Contenido = contenido;
    }
}
