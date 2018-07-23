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

        public Form3()
        {
            InitializeComponent();                      
        }

        private void BindListBox()
        {
            contatos = SContatos.Read();
            listBox1.DataSource = contatos.Contato;
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "Id";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BindListBox();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = NextId();
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;

            contatos.Contato.Add(c);

            SContatos.Write(contatos);
            BindListBox();            
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
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado");
            }
        }
    }
}
