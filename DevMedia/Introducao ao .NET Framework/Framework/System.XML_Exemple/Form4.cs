using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.XML_Exemple
{
    public partial class Form4 : Form
    {
        Contatos contatos = null;
        List<Contato> resultado = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            contatos = SContatos.Read();
            try
            {

                if (cmbCampo.SelectedItem.Equals("Nome"))
                {
                    resultado = contatos.Contato.Where(p => p.Nome.Contains(txtBusca.Text)).ToList<Contato>();
                }
                else if (cmbCampo.SelectedItem.Equals("Telefone"))
                {
                    resultado = contatos.Contato.Where(p => p.Telefone.Exists(t => t.Numero.Equals(txtBusca.Text))).ToList<Contato>();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algum erro ocorreu ao tentar realizar a busca");
            }

            FiltroContatos.Filtro = resultado;
            this.Close();
        }
    }
}
