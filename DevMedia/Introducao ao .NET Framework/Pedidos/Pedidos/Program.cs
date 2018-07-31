using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido(new Cartao());
            pedido.Pagar(2000);

            Console.ReadLine();
        }
    }
}
