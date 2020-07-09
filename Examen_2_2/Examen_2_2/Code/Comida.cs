using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2_2.Code
{
    public abstract class Comida
    {
        public List<Ingrediente> Ingredientes;

        public double GetPrecio()
        {
            double precio = 0.0;
            for (int i = 0; i < Ingredientes.Count; i++)
            {
                precio += Ingredientes[i].GetPrecio();
            }
            return precio;
        }
    }
}
