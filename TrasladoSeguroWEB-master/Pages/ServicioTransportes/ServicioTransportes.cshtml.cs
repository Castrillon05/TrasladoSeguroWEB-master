using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TrasladoSeguroWEB.Pages.ServicioTransportes
{
    [Authorize]
    public class ServicioTransportesModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
