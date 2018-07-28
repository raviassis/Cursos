using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Aplicacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConStr = ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;
            using (var con = new SqlConnection(ConStr))
            {
                con.Open();
                var trans = con.BeginTransaction();
                try
                {
                    var sql1 = "insert into Clientes(NomeCliente, EmailCliente) values (@NomeCliente, @EmailCliente);";
                    var sql1Erro = "insert into Clientes(NomeCliente) values (@NomeCliente);";
                    var sql2 = "delete Clientes where IdCliente = 3";
                    var cmd1 = con.CreateCommand();
                    var cmd2 = con.CreateCommand();
                    cmd1.CommandText = sql1Erro;
                    cmd2.CommandText = sql2;
                    cmd1.Transaction = trans;
                    cmd2.Transaction = trans;
                    cmd1.Parameters.AddWithValue("@NomeCliente", "José2");
                    //cmd1.Parameters.AddWithValue("@EmailCliente", "jose@gmail.com");
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    trans.Commit();
                    Console.WriteLine("Comandos Executados com sucesso");
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    Console.WriteLine("Erro ao executar transação");
                    Console.WriteLine(e.GetType());
                    Console.WriteLine(e.Message);
                }

                Console.ReadKey();
            }
        }
    }
}
