using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examen_2_2.Pages
{
    public class FormularioModel : PageModel
    {
        public List<int> listaIngredientes;

        [BindProperty]
        public string Anotaciones { get; set; }

        [BindProperty]
        public int Masa { set; get; }

        [BindProperty]
        public List<int> ListaIngredientesSelec { get; set; }

        [BindProperty]
        public int Tamano { get; set; }

        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult OnPost()
        {
            Anotaciones = "";
            if (ListaIngredientesSelec.Count == 0)
            {
                
            }
            return Page();
        }

        public void OnGet()
        {

        }
    }
}