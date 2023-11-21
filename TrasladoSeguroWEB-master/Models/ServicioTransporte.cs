namespace TrasladoSeguroWEB.Models
{
    public class ServicioTransporte
    {
        public int Id { get; set; }

        public string? NombreConductor { get; set; }

        public string Fecha { get; set; }

        public string? Description { get; set; }

        public ICollection<Cliente>? Clientes { get; set; } = default!;
    }
}
