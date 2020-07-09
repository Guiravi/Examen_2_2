using Examen_2_2.Clases_Abstractas;


namespace Examen_2_2.Clases_Concretas
{
    public class PastaTomate : Ingrediente
    {
        public override string GetNombre()
        {
            return "Pasta de Tomate";
        }

        public override double GetPrecio()
        {
            return 600;
        }
    }
}
