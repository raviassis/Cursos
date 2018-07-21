using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCalculadoraDeSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInt = 0;
            int mesInt = 0;
            string dia, mes;
            InterpretadorSignos interpretador = new InterpretadorSignos();
            Signo signo;

            Console.Write("Em que dia você nasceu? ");
            dia = Console.ReadLine();

            Console.Write("Em que mês você nasceu? ");
            mes = Console.ReadLine();

            try
            {
                diaInt = int.Parse(dia);
                mesInt = int.Parse(mes);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }

            signo = interpretador.Interpretar(diaInt, mesInt);

            if (signo != null)
                Console.WriteLine("Seu signo é " + signo.nome);
            else
                Console.WriteLine("Não foi possivel interpretar o seu signo.");
            Console.ReadLine();
        }
    }
}
