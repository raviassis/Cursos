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

namespace System.XML_Exemple
{
    public partial class Form2 : Form
    {
        string arquivo = @"D:\Aulas\Agenda2.xml";
        XmlDocument xml = new XmlDocument();

        public Form2()
        {
            InitializeComponent();

            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xml.CreateElement("Contatos");
                xml.AppendChild(nodeRoot);
                xml.Save(arquivo);
            }

            ReadAgenda();
        }

        private void ReadAgenda()
        {
            xml.Load(arquivo);
            lblAgenda.Text = "";
            foreach (XmlNode node in xml.SelectNodes("Contatos/Contato"))
            {
                lblAgenda.Text += "Nome: " + node.Attributes["nome"].Value;
                lblAgenda.Text += " Telefone: " + node.Attributes["telefone"].Value;
                lblAgenda.Text += "\n";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add(txtNome.Text, txtTelefone.Text);
            ReadAgenda();
        }

        private void Add(string nome, string telefone)
        {
            XElement xE = new XElement("Contato");
            xE.Add(new XAttribute("nome", nome));
            xE.Add(new XAttribute("telefone", telefone));
            XElement xDoc = XElement.Load(arquivo);
            xDoc.Add(xE);
            xDoc.Save(arquivo);            
        }
    }
}
