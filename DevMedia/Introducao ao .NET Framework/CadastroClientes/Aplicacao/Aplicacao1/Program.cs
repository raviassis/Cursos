using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Aplicacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe Nome do Cliente: ");
            var NomeCliente = Console.ReadLine();
            Console.WriteLine("Informe Email do Cliente: ");
            var Email = Console.ReadLine();

            var ConStr = ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;
            var con = new SqlConnection(ConStr);
            //var sql = "insert into Clientes(NomeCliente, EmailCliente) values (@NomeCliente, @EmailCliente);";

            var sql = "InsertCliente";
            var cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NomeCliente", NomeCliente);
            cmd.Parameters.AddWithValue("@EmailCliente", Email);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Registro inserido com sucesso!");
            }
            finally
            {
                con.Close();
            }

        }

    }
}
