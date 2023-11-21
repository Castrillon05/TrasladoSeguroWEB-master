using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrasladoSeguroWEB.Data;
using TrasladoSeguroWEB.Models;

namespace TrasladoSeguroWEB.Pages.ServicioTransportes
{
    public class CreateModel : PageModel
    {
        private readonly TrasladoSeguroContext _context;

        public CreateModel(TrasladoSeguroContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]

        public ServicioTransporte ServicioTransporte { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.ServicioTransportes == null || ServicioTransporte == null)
            {
                return Page();
            }

            _context.ServicioTransportes.Add(ServicioTransporte);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        
    }
}
