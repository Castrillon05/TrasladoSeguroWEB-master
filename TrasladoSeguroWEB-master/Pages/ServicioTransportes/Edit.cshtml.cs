using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TrasladoSeguroWEB.Data;
using TrasladoSeguroWEB.Models;

namespace TrasladoSeguroWEB.Pages.ServicioTransportes
{
    public class EditModel : PageModel
    {
        private readonly TrasladoSeguroContext _context;

        public EditModel(TrasladoSeguroContext context)
        {
            _context = context;
        }


        [BindProperty]

        public ServicioTransporte ServicioTransporte { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ServicioTransportes == null)
            {
                return NotFound();
            }

            var serviciotransporte = await _context.ServicioTransportes.FirstOrDefaultAsync(m => m.Id == id);

            if (ServicioTransporte == null)
            {
                return NotFound();
            }
            ServicioTransporte = ServicioTransporte;
            return Page();


        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ServicioTransporte).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!ServicioTransporteExists(ServicioTransporte.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ServicioTransporteExists(int id)
        {

            return (_context.ServicioTransportes?.Any(e => e.Id == id)).GetValueOrDefault();

        }
       
    }
}
