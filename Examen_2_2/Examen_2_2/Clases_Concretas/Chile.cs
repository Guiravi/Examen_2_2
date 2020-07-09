using Examen_2_2.Clases_Abstractas;


namespace Examen_2_2.Clases_Concretas
{
    public class Chile : Ingrediente
    {
        public override string GetNombre()
        {
            return "Chile";
        }

        public override double GetPrecio()
        {
            return 275.2;
        }
    }
}
