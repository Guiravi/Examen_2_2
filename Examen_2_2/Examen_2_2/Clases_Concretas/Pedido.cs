using Examen_2_2.Clases_Abstractas;
using System.Collections.Generic;

namespace Examen_2_2.Clases_Concretas
{
    public class Pedido
    {
        public List<Comida> ComidaPedido;

        private string Anotaciones;

        public Pedido()
        {
            ComidaPedido = new List<Comida>();
        }

        public Comida AddComida(Comida comida)
        {
            ComidaPedido.Add(comida);
            return comida;
        }

        public string AddAnotaciones(string anotaciones)
        {
            Anotaciones = anotaciones;
            return Anotaciones;
        }

        public string GetAnotaciones()
        {
            return Anotaciones;
        }

        public double GetPrecio()
        {
            double precio = 0.0;
            for (int i = 0; i < ComidaPedido.Count; i++)
            {
                precio += ComidaPedido[i].GetPrecio();
            }
            return precio;
        }
    }
}
