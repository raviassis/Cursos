using RAssis.Entidades;
using RAssis.Util;
using System;



namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica c1 = new PessoaFisica();
            c1.Codigo = 123;
            c1.Nome = "Ravi";
            c1.CPF = "12345678900";
            c1.Mostrar();

            PessoaJuridica c2 = new PessoaJuridica();
            c2.Codigo = 456;
            c2.Nome = "RAssis";
            c2.CNPJ = "987654321654987654321";
            c2.Mostrar();

            Console.ReadLine();
        }
    }
}
