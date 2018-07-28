using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Aplicacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConStr = ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;

            using (var con = new SqlConnection(ConStr))
            {
                //var sql = "select [IdCliente], [NomeCliente], [EmailCliente] from [Clientes]";
                var cmd = con.CreateCommand();
                cmd.CommandText = "SelectClientesProdutos";
                con.Open();
                var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                Console.WriteLine("Listagem de Clientes");
                Console.WriteLine("--------------------");
                while (dr.Read())
                {
                    Console.WriteLine("ID: "+ dr[0].ToString());
                    Console.WriteLine("Nome: " + dr[1].ToString());
                    Console.WriteLine("Email: " + dr[2].ToString());
                }

                dr.NextResult();
                Console.WriteLine("\n\nListagem de Produtos");
                Console.WriteLine("--------------------");
                while (dr.Read())
                {
                    Console.WriteLine("ID: " + dr[0].ToString());
                    Console.WriteLine("NomeProduto: " + dr[1].ToString());
                }

                dr.Close();
                Console.ReadKey();
            }
        }
    }
}
