using Examen_2_2.Clases_Abstractas;


namespace Examen_2_2.Clases_Concretas
{
    public class Tomate : Ingrediente
    {
        public override string GetNombre()
        {
            return "Tomate";
        }

        public override double GetPrecio()
        {
            return 300;
        }
    }
}
