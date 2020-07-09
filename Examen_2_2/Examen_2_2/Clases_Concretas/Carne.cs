using Examen_2_2.Clases_Abstractas;

namespace Examen_2_2.Clases_Concretas
{
    public class Carne : Ingrediente
    {
        public override string GetNombre()
        {
            return "Carne";
        }

        public override double GetPrecio()
        {
            return 1000;
        }
    }
}
