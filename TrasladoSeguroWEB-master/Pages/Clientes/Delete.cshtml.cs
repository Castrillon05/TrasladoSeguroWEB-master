using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrasladoSeguroWEB.Data;
using TrasladoSeguroWEB.Models;

namespace TrasladoSeguroWEB.Pages.Clientes
{
    public class DeleteModel : PageModel
    {
        private readonly TrasladoSeguroContext _context;

        public DeleteModel(TrasladoSeguroContext context)
        {
            _context = context;
        }


        [BindProperty]

        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Clientes == null)
            {
                return NotFound();
            }

            var product = await _context.Clientes.FindAsync(id);

            if (product != null)
            {
                Cliente = Cliente;
                _context.Clientes.Remove(product);
                await _context.SaveChangesAsync();
            }


            return RedirectToPage("./Index");
        }
        public void OnGet()
        {
        }
    }
}
