namespace Entidades
{
    public class ETPréstamo
    {
        public int IdPréstamo { get; set; }
        public int IdPrestatario { get; set; }
        public int IdTécnico { get; set; }
        public int IdEstadoCreación { get; set; }
        public DateTime FechaCreación { get; set; }
        public DateTime FechaDevolución { get; set; }
    }
}
