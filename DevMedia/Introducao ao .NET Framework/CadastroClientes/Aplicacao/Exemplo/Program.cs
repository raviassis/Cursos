using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConStr = ConfigurationManager.ConnectionStrings["Cadastro"].ConnectionString;
            var con = new SqlConnection(ConStr);
            var sql = "select * from Clientes";
            var cmd = new SqlCommand(sql, con);
            var ds = new DataSet("Cadastro");
            var da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Clientes");
            var dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("IDCliente: " + row[0].ToString());
                Console.WriteLine("Nome Cliente: " + row[1].ToString());
                Console.WriteLine("Email: " + row[2].ToString());
            }

            dt.WriteXml("dados.xml");
            Console.ReadKey();
        }
    }
}
