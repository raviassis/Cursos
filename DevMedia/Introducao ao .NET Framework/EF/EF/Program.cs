using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultarCliente1();
            ConsultarCliente2();
            ConsultarCliente3();
        }

        private static void ConsultarCliente3()
        {
            var db = new CadastroEntities();
            var qry = from c in db.Contatos
                      select new { Nome = c.Cliente.NomeCliente, Contato = c.Contato1 };
            foreach (var cli in qry)
            {
                Console.WriteLine(cli.Nome + " - " + cli.Contato);
            }

            Console.ReadKey();
        }

        private static void ConsultarCliente2()
        {
            var db = new CadastroEntities();
            var qry = from cli in db.Clientes
                      where cli.NomeCliente.Contains("r")
                      orderby cli.IdCliente descending
                      select cli;
            foreach (var c in qry)
            {
                Console.WriteLine(c.IdCliente + " - " + c.NomeCliente + " - " + c.EmailCliente);
            }

            Console.ReadKey();
        }

        private static void ConsultarCliente1 ()
        {
            var db = new CadastroEntities();
            foreach (var cli in db.Clientes)
            {
                Console.WriteLine(cli.NomeCliente);
                foreach (var cont in cli.Contatos)
                {
                    Console.WriteLine(cont.Tipo);
                    Console.WriteLine(cont.Contato1);
                }
            }
        }

        private static void Inserir ()
        {
            var db = new CadastroEntities();
            var cli = new Cliente()
            {
                NomeCliente = "Wesley",
                EmailCliente = "wesley@gmail.com"
            };

            var cont1 = new Contato()
            {
                Tipo = "Email",
                Contato1 = "wesley@gmail.com",
                Cliente = cli
            };
            var cont2 = new Contato()
            {
                Tipo = "Fone",
                Contato1 = "9999-9999",
                Cliente = cli
            };

            db.Contatos.Add(cont1);
            db.Contatos.Add(cont2);
            db.Clientes.Add(cli);
            db.SaveChanges();

            Console.WriteLine("Registros inseridos com sucesso.");
        }
    }
}
