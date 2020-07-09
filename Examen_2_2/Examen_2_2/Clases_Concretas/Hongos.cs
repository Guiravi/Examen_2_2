using Examen_2_2.Clases_Abstractas;


namespace Examen_2_2.Clases_Concretas
{
    public class Hongos : Ingrediente
    {
        public override string GetNombre()
        {
            return "Hongos";
        }

        public override double GetPrecio()
        {
            return 250;
        }
    }
}
