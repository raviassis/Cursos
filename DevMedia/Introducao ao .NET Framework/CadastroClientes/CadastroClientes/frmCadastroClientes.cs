using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CadastroClientes
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            DataTable tabela = CriarEstruturaTabela();
            dataSet.Tables.Add(tabela);

            DataRow registro = CriarRegistro(tabela);
            tabela.Rows.Add(registro);
            dataSet.WriteXml(@".\cliente_" + txtCodigo.Text + ".xml");
        }

        private DataRow CriarRegistro(DataTable tabela)
        {
            DataRow registro = tabela.NewRow();
            registro["Codigo"] = txtCodigo.Text;
            registro["Nome"] = txtNome.Text;
            registro["Fone"] = txtTelefone.Text;
            registro["Email"] = txtEmail.Text;
            return registro;
        }

        private static DataTable CriarEstruturaTabela()
        {
            DataTable tabela = new DataTable("Clientes");
            tabela.Columns.Add(new DataColumn("Codigo"));
            tabela.Columns.Add(new DataColumn("Nome"));
            tabela.Columns.Add(new DataColumn("Fone"));
            tabela.Columns.Add(new DataColumn("Email"));
            return tabela;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@".\cliente_" + txtCodigo.Text + ".xml");
            DataTable tabela = dataSet.Tables[0];
            DataRow registro = tabela.Rows[0];
            MostrarDadosTela(registro);
        }

        private void MostrarDadosTela(DataRow registro)
        {
            txtNome.Text = registro["Nome"].ToString();
            txtTelefone.Text = registro["Fone"].ToString();
            txtEmail.Text = registro["Email"].ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control txt in Controls)
            {
                if (txt is TextBox) (txt as TextBox).Clear();
            }
        }
    }
}
