using Examen_2_2.Clases_Abstractas;

namespace Examen_2_2.Clases_Concretas
{
    public class MasaArtesanal : Ingrediente
    {
        public override string GetNombre()
        {
            return "Masa Artesanal";
        }

        public override double GetPrecio()
        {
            return 1000;
        }
    }
}
