using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace System.XML_Exemple
{
    public partial class Form3 : Form
    {
        //string arquivo = @"D:\Aulas\Agenda.xml";
        //XmlDocument xml = new XmlDocument();
        //XElement xE;
        Contatos contatos;
        int auxId;

        public Form3()
        {
            InitializeComponent();                      
        }

        private void BindListBox(Contatos contatos)
        {
            
            listBox1.DataSource = contatos.Contato;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Id";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            contatos = SContatos.Read();
            BindListBox(contatos);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = NextId();
            c.Nome = txtNome.Text;
            c.Telefone = new List<Telefone>();
            c.Telefone.Add(new Telefone( (int) TiposTelefone.Residencial , txtFoneResidencial.Text));
            c.Telefone.Add(new Telefone( (int) TiposTelefone.Comercial, txtFoneComercial.Text));
            c.Telefone.Add(new Telefone( (int) TiposTelefone.Celular, txtCelular.Text));
            c.Obs = txtObs.Text;

            contatos.Contato.Add(c);

            SContatos.Write(contatos);
            BindListBox(SContatos.Read());            
        }

        private int NextId()
        {

            return (contatos.Contato.Count == 0) ? 1 : contatos.Contato[contatos.Contato.Count - 1].Id + 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Contato c = contatos.Contato.Find(p => p.Id == (int) listBox1.SelectedValue);
                contatos.Contato.Remove(c);
                SContatos.Write(contatos);
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }

            BindListBox(SContatos.Read());
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Contato c = contatos.Contato.Find(p => p.Id == (int) listBox1.SelectedValue);
            StringBuilder msg = new StringBuilder();
            msg.Append("Nome: " + c.Nome + "\n");
            msg.Append("Fone Residencial: " + c.Telefone.Find(p => p.Tipo == 0).Numero + "\n");
            msg.Append("Fone Comercial: " + c.Telefone.Find(p => p.Tipo == 1).Numero + "\n");
            msg.Append("Celular: " + c.Telefone.Find(p => p.Tipo == 2).Numero + "\n");
            msg.Append("Observação: " + c.Obs);
            MessageBox.Show(msg.ToString());
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Contato c = contatos.Contato.Find(p => p.Id == (int)listBox1.SelectedValue);
                txtNome.Text = c.Nome;

                if (c.Telefone.Count > 0)
                {
                    txtFoneResidencial.Text = c.Telefone.Find( p => p.Tipo == (int) TiposTelefone.Residencial).Numero;
                    txtFoneComercial.Text = c.Telefone.Find(p => p.Tipo == (int)TiposTelefone.Comercial).Numero;
                    txtCelular.Text = c.Telefone.Find(p => p.Tipo == (int)TiposTelefone.Celular).Numero;
                }
                
                txtObs.Text = c.Obs;
                auxId = c.Id;
                
                pnlIncluir.Visible = false;
                pnlAlterar.Visible = true;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
        }

        private void btnSAlterar_Click(object sender, EventArgs e)
        {
            Contato c = contatos.Contato.Find(p => p.Id == auxId);
            c.Nome = txtNome.Text;
            c.Telefone = new List<Telefone>();
            c.Telefone.Add(new Telefone((int)TiposTelefone.Residencial, txtFoneResidencial.Text));
            c.Telefone.Add(new Telefone((int)TiposTelefone.Comercial, txtFoneComercial.Text) );
            c.Telefone.Add(new Telefone((int)TiposTelefone.Celular, txtCelular.Text));
            c.Obs = txtObs.Text;

            SContatos.Write(contatos);

            btnCancelar_Click(null, null);
            BindListBox(SContatos.Read());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            auxId = -1;
            pnlAlterar.Visible = false;
            pnlIncluir.Visible = true;
            txtNome.Text = txtFoneResidencial.Text = txtFoneComercial.Text = txtCelular.Text = txtObs.Text = string.Empty;
        }

        private void btnTelaBusca_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.FormClosed += F4_FormClosed;
            f4.ShowDialog();
        }

        private void F4_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FiltroContatos.Filtro.Count > 0)
            {
                Contatos c = new Contatos();
                c.Contato = FiltroContatos.Filtro;
                this.BindListBox(c);
                btnRemoveFiltro.Visible = true;
            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado");
            }
        }

        private void btnRemoveFiltro_Click(object sender, EventArgs e)
        {
            btnRemoveFiltro.Visible = false;
            this.BindListBox(contatos);
        }
    }
}
