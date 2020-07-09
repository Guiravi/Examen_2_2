using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2_2.Code
{
    public abstract class Ingrediente
    {
        private string Nombre;
        private double Precio;

        public string GetNombre()
        {
            return Nombre;
        }

        public double GetPrecio()
        {
            return Precio;
        }
    }
}
