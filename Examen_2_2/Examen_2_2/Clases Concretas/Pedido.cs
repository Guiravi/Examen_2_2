using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_2_2.Code
{
    public class Pedido
    {
        public List<Comida> ComidaPedido;

        public Pedido()
        {
            ComidaPedido = new List<Comida>();
        }

        public Comida AddComida(Comida comida)
        {
            ComidaPedido.Add(comida);
            return comida;
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
