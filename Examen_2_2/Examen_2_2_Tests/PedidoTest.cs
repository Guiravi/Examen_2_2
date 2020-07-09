using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen_2_2.Clases_Abstractas;
using Examen_2_2.Clases_Concretas;


namespace Examen_2_2_Tests
{
    [TestClass]
    class PedidoTest
    {
        Pedido pedido;
        Comida comida;
        Pizza pizza;
        Ingrediente ingrediente;
        Carne carne = new Carne();

        public PedidoTest()
        {
            pedido = new Pedido();
            pizza = new Pizza();
            carne = new Carne();
            comida = pizza;
            ingrediente = carne;
        }

        [TestMethod]
        public void TestGetPrecio()
        {
            pedido.AddComida(comida);

            pedido.ComidaPedido[0].AddIngrediente(ingrediente);

            pedido.GetPrecio();
        }
    }
}
