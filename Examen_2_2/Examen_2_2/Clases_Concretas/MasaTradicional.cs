using Examen_2_2.Clases_Abstractas;

namespace Examen_2_2.Clases_Concretas
{
    public class MasaTradicional : Ingrediente
    {
        public override string GetNombre()
        {
            return "Masa Tradicional";
        }

        public override double GetPrecio()
        {
            return 900;
        }
    }
}