using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrasladoSeguroWEB.Data;
using TrasladoSeguroWEB.Models;

namespace TrasladoSeguroWEB.Pages.Clientes
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly TrasladoSeguroContext _context;

        public IndexModel(TrasladoSeguroContext context)
        {
            _context = context;
        }

        public IList<Cliente> Clientes { get; set; } = default!;



        public async Task OnGetAsync()
        {
            if (_context.Clientes != null)
            {
                Clientes = await _context.Clientes.ToListAsync();
            }

        }
        public void OnGet()
        {
        }
    }
}
