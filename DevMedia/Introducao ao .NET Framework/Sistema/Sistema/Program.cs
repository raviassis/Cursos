using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(TipoConta.ContaCorrente, "13654");
            
            conta.Depositar(500);
            conta.Sacar(300);
            Console.WriteLine(conta.GetSaldo());
            Console.ReadLine();
        }
    }
}
