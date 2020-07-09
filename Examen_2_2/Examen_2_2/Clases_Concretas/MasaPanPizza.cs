using Examen_2_2.Clases_Abstractas;

namespace Examen_2_2.Clases_Concretas
{
    public class MasaPanPizza : Ingrediente
    {
        public override string GetNombre()
        {
            return "Masa Pan Pizza";
        }

        public override double GetPrecio()
        {
            return 800;
        }
    }
}