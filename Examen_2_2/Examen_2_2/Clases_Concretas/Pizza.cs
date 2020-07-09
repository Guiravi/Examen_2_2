using Examen_2_2.Clases_Abstractas;
using System.Collections.Generic;

namespace Examen_2_2.Clases_Concretas
{
    public class Pizza : Comida
    {
        public Pizza()
        {
            Comida comida = this;
            comida.Ingredientes = new List<Ingrediente>();
        }

        public override string GetNombre()
        {
            return "Pizza";
        }
    }
}
