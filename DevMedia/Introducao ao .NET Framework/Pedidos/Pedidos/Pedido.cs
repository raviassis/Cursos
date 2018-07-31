using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public abstract class FormPagamento
    {
        public abstract void Pagar(double valor);
    }

    public class Boleto : FormPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago valor de {0} no boleto", valor);
        }
    }

    public class Cartao : FormPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago valor de {0} no cartão", valor);
        }
    }

    public class Pedido
    {
        private FormPagamento forma;

        public void Pagar (double valor)
        {
            forma.Pagar(valor);
        }

        public Pedido(FormPagamento f)
        {
            forma = f;
        }
    }
}
