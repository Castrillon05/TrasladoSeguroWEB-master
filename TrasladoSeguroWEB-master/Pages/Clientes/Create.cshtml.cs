using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrasladoSeguroWEB.Data;
using TrasladoSeguroWEB.Models;

namespace TrasladoSeguroWEB.Pages.Clientes
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

        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Clientes == null || Cliente == null)
            {
                return Page();
            }

            _context.Clientes.Add(Cliente);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        
    }
}
