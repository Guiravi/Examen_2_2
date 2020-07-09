using System.Collections.Generic;

namespace Examen_2_2.Clases_Abstractas
{
    public abstract class Comida
    {
        public List<Ingrediente> Ingredientes;
        private string tamano;

        public abstract string GetNombre();

        public string SetTamano(string tam)
        {
            tamano = tam;
            return tamano;
        }

        public string GetTamano()
        {
            return tamano;
        }

        public double GetPrecio()
        {
            double precio = 0.0;
            for (int i = 0; i < Ingredientes.Count; i++)
            {
                precio += Ingredientes[i].GetPrecio();
            }
            return precio;
        }

        public Ingrediente AddIngrediente(Ingrediente ingrediente)
        {
            Ingredientes.Add(ingrediente);
            return ingrediente;
        }
    }
}
