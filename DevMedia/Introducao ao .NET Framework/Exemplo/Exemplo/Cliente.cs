using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAssis.Entidades
{
    public class Cliente
    {
        public int Codigo;
        public string Nome;

        public void Mostrar()
        {
            Console.WriteLine("Dados do Cliente: {0}-{1}", Codigo, Nome);
        }
    }

    public class PessoaFisica : Cliente
    {
        public string CPF;

        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CPF: " + CPF);
        }
    }

    public class PessoaJuridica : Cliente
    {
        public string CNPJ;

        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CNPJ: " + CNPJ);
        }
    }
}
