using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen_2_2.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnPostEntrarFormulario()
        {
            return Redirect("Formulario");
        }


        public void OnGet()
        {

        }
    }
}
