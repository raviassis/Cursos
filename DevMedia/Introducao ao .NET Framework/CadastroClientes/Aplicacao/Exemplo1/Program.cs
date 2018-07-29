using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConStr = ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;
            var con = new SqlConnection(ConStr);
            var sql1 = "select * from Clientes";
            var sql2 = "select * from Contatos";
            var cmd1 = new SqlCommand(sql1, con);
            var cmd2 = new SqlCommand(sql2, con);
            var ds = new DataSet("Clientes");
            var da1 = new SqlDataAdapter(cmd1);
            var da2 = new SqlDataAdapter(cmd2);
            da1.Fill(ds, "Clientes");
            da2.Fill(ds, "Contatos");
            var dtClientes = ds.Tables[0];
            var dtContatos = ds.Tables[1];
            DataRelation relation = ds.Relations.Add(
                    "ClientesContatos",
                    dtClientes.Columns["IdCliente"],
                    dtContatos.Columns["IdCliente"]
            );

            foreach (DataRow cli in dtClientes.Rows)
            {
                Console.WriteLine("Nome Cliente: " + cli[1].ToString());
                foreach (DataRow cont in cli.GetChildRows(relation))
                {
                    Console.WriteLine(cont[1].ToString() + " - " + cont[2].ToString());
                }
            }

            Console.ReadKey();

        }
    }
}
