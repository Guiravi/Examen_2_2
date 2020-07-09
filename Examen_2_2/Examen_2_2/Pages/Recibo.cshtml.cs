using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen_2_2.Pages
{
    public class ReciboModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Precio { get; set; }

        [BindProperty(SupportsGet = true)]
        public string TipoComida { get; set; }

        public void OnGet()
        {

        }
    }
}