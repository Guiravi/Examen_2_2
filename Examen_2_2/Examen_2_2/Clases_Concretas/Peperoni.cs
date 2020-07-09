using Examen_2_2.Clases_Abstractas;


namespace Examen_2_2.Clases_Concretas
{
    public class Peperoni : Ingrediente
    {
        public override string GetNombre()
        {
            return "Peperoni";
        }

        public override double GetPrecio()
        {
            return 500;
        }
    }
}
