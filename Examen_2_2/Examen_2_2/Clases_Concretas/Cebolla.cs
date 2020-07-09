using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen_2_2.Clases_Abstractas;


namespace Examen_2_2.Clases_Concretas
{
    public class Cebolla : Ingrediente
    {
        public override string GetNombre()
        {
            return "Cebolla";
        }

        public override double GetPrecio()
        {
            return 100;
        }
    }
}
