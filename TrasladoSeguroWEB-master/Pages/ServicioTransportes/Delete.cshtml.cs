using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrasladoSeguroWEB.Data;
using TrasladoSeguroWEB.Models;

namespace TrasladoSeguroWEB.Pages.ServicioTransportes
{
    public class DeleteModel : PageModel
    {
        private readonly TrasladoSeguroContext _context;

        public DeleteModel(TrasladoSeguroContext context)
        {
            _context = context;
        }


        [BindProperty]

        public ServicioTransporte ServicioTransporte { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ServicioTransportes == null)
            {
                return NotFound();
            }

            var serviciotransporte = await _context.ServicioTransportes.FindAsync(id);

            if (serviciotransporte != null)
            {
                ServicioTransporte = ServicioTransporte;
                _context.ServicioTransportes.Remove(ServicioTransporte);
                await _context.SaveChangesAsync();
            }


            return RedirectToPage("./Index");
        }
      
    }
}
