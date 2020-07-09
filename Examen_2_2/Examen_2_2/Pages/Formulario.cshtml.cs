using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Examen_2_2.Clases_Abstractas;
using Examen_2_2.Clases_Concretas;

namespace Examen_2_2.Pages
{
    public class FormularioModel : PageModel
    {
        public List<Ingrediente> listaIngredientes;
        public Pedido pedido;

        [BindProperty]
        public string Anotaciones { get; set; }

        [BindProperty]
        public int Masa { set; get; }

        [BindProperty]
        public List<string> ListaIngredientesSelec { get; set; }

        [BindProperty]
        public int Tamano { get; set; }

        public FormularioModel()
        {
            ListaIngredientesSelec = new List<string>();
            listaIngredientes = new List<Ingrediente>();
            pedido = new Pedido();
            Pizza pizza = new Pizza();
            pedido.AddComida(pizza);

        }

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