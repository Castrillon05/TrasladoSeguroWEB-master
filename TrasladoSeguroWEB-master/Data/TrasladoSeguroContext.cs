using Microsoft.EntityFrameworkCore;
using TrasladoSeguroWEB.Models;

namespace TrasladoSeguroWEB.Data
{
    public class TrasladoSeguroContext : DbContext
    {
        public TrasladoSeguroContext(DbContextOptions options) : base(options) 
        { 
        }

        public DbSet<Cliente> Clientes { get; set;}

        public DbSet<ServicioTransporte> ServicioTransportes { get; set;}
    }
}
