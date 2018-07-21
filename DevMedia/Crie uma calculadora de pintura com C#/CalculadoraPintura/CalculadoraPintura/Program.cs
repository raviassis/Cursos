using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura;
            double profundidade;
            Calculadora cal = new Calculadora();
            const double ALTURA = 2.9;
            const int RENDIMENTO_TINTA = 10;

            Console.WriteLine("Qual a largura do cômodo?");
            largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a profundidade do cômodo?");
            profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("A área das Paredes é: " + cal.calcularAreaParedes(largura, profundidade, ALTURA) );
            Console.WriteLine("A área do teto é: " + cal.calcularAreaTeto(largura, profundidade) );
            Console.WriteLine("A litragem de tinta necessária é: " + cal.calcularLitragem(RENDIMENTO_TINTA) );
            Console.ReadLine();
        }
    }
}
