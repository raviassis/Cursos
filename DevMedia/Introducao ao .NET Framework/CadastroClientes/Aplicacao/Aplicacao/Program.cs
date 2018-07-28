using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var Connection = getConnectionString();

            using (SqlConnection con = new SqlConnection(Connection))
            {
                Console.WriteLine("String de conexão: " + Connection);
                con.Open();
                Console.WriteLine("Conexão com o Banco de Dados Efetuada com sucesso...");
                Console.WriteLine("Estado da conexão: " + con.State);
                con.Close();
                Console.WriteLine("Estado da conexão: " + con.State);
            }

            Console.ReadKey();

        }

        private static string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;
        }

        private static string getConnectionStringBuilder()
        {
            SqlConnectionStringBuilder ConBuilder = new SqlConnectionStringBuilder();
            ConBuilder.DataSource = @"(localDB)\MSSQLLocalDB";
            ConBuilder.InitialCatalog = "Cadastro";
            ConBuilder.IntegratedSecurity = true;
            return ConBuilder.ConnectionString;
        }
    }
}
