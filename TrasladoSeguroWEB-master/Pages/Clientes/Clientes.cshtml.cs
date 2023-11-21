using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrasladoSeguroWEB.Pages.Clientes
{
    [Authorize]
    public class ClientesModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
