using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Examen_2_2.Clases_Abstractas;
using Examen_2_2.Clases_Concretas;
using System.ComponentModel.DataAnnotations;

namespace Examen_2_2.Pages
{
    public class FormularioModel : PageModel
    {
        public List<Ingrediente> listaIngredientes;
        public Pedido pedido;

        [BindProperty]
        public string Anotaciones { get; set; }


        [Required(ErrorMessage = "Seleccione un tipo de masa por favor")]
        [BindProperty]
        public int Masa { set; get; }

        [Required(ErrorMessage = "Seleccione al menos un ingrediente por favor")]
        [BindProperty]
        public List<string> ListaIngredientesSelec { get; set; }

        [Required(ErrorMessage = "Seleccione un tamaño por favor")]
        [BindProperty]
        public int Tamano { get; set; }

        public FormularioModel()
        {
            ListaIngredientesSelec = new List<string>();
            listaIngredientes = new List<Ingrediente>();
            pedido = new Pedido();
            Pizza pizza = new Pizza();
            pedido.AddComida(pizza);
            CrearIngredientesPizza();
            Anotaciones = "";
            Masa = 0;
            Tamano = 0;
        }

        public void CrearIngredientesPizza()
        {
            Carne carne = new Carne();
            Cebolla cebolla = new Cebolla();
            Chile chile = new Chile();
            Hongos hongos = new Hongos();
            PastaTomate pastaTomate = new PastaTomate();
            Peperoni peperoni = new Peperoni();
            Pina pina = new Pina();
            Queso queso = new Queso();
            Tomate tomate = new Tomate();
            listaIngredientes.Add(carne);
            listaIngredientes.Add(cebolla);
            listaIngredientes.Add(chile);
            listaIngredientes.Add(hongos);
            listaIngredientes.Add(pastaTomate);
            listaIngredientes.Add(peperoni);
            listaIngredientes.Add(pina);
            listaIngredientes.Add(queso);
            listaIngredientes.Add(tomate);
        }

        [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
        public IActionResult OnPost()
        {
            if (ListaIngredientesSelec.Count == 0)
            {
                return Page();
            }
            for (int i = 0; i < ListaIngredientesSelec.Count; i++)
            {
                bool encontrado = false;
                for (int j = 0; j < listaIngredientes.Count && !encontrado; j++)
                {
                    if (ListaIngredientesSelec[i] == listaIngredientes[i].GetNombre())
                    {
                        pedido.ComidaPedido[0].AddIngrediente(listaIngredientes[i]);
                        encontrado = true;
                    }
                }
            }
            pedido.AddAnotaciones(Anotaciones);
            if (Tamano == 0)
            {
                pedido.ComidaPedido[0].SetTamano("Pequeña");
            }
            else if (Tamano == 1)
            {
                pedido.ComidaPedido[0].SetTamano("Mediana");
            }
            else
            {
                pedido.ComidaPedido[0].SetTamano("Grande");
            }

            if (Masa == 0)
            {
                MasaArtesanal artesanal = new MasaArtesanal();
                pedido.ComidaPedido[0].AddIngrediente(artesanal);
            }
            else if (Masa == 1)
            {
                MasaTradicional tradicional = new MasaTradicional();
                pedido.ComidaPedido[0].AddIngrediente(tradicional);
            }
            else
            {
                MasaPanPizza panPizza = new MasaPanPizza();
                pedido.ComidaPedido[0].AddIngrediente(panPizza);
            }

            return Redirect("/Recibo/" + pedido.ComidaPedido[0].GetNombre() + "/" + ((Tamano+1)*pedido.ComidaPedido[0].GetPrecio()).ToString());
        }

        public void OnGet()
        {

        }
    }
}