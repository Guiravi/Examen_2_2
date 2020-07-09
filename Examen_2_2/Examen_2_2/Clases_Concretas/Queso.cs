using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen_2_2.Clases_Abstractas;


namespace Examen_2_2.Clases_Concretas
{
    public class Queso : Ingrediente
    {
        public override string GetNombre()
        {
            return "Queso";
        }

        public override double GetPrecio()
        {
            return 700;
        }
    }
}
