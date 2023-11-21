using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrasladoSeguroWEB.Data;
using TrasladoSeguroWEB.Models;

namespace TrasladoSeguroWEB.Pages.ServicioTransportes
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly TrasladoSeguroContext _context;

        public IndexModel(TrasladoSeguroContext context)
        {
            _context = context;
        }

        public IList<ServicioTransporte> ServicioTransportes { get; set; } = default!;



        public async Task OnGetAsync()
        {
            if (_context.Clientes != null)
            {
                ServicioTransportes = await _context.ServicioTransportes.ToListAsync();
            }

        }
        
    }
}
