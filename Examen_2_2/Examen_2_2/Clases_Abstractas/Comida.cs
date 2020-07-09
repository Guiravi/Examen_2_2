using System.Collections.Generic;

namespace Examen_2_2.Clases_Abstractas
{
    public abstract class Comida
    {
        public List<Ingrediente> Ingredientes;

        public abstract string GetNombre();

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
