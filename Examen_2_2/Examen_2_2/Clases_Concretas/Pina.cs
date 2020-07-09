using Examen_2_2.Clases_Abstractas;


namespace Examen_2_2.Clases_Concretas
{
    public class Pina : Ingrediente
    {
        public override string GetNombre()
        {
            return "Piña";
        }

        public override double GetPrecio()
        {
            return 800;
        }
    }
}
