using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace System.XML_Exemple
{
    public partial class Form1 : Form
    {
        string arquivo = @"D:\Aulas\Agenda.xml";
        XmlDocument xml = new XmlDocument();

        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            XmlNode nodeNome = xml.CreateElement("Nome");
            XmlNode nodeTelefone = xml.CreateElement("Telefone");
            XmlNode nodeContato = xml.CreateElement("Contato");

            nodeNome.InnerText = txtNome.Text;
            nodeTelefone.InnerText = txtTelefone.Text;

            xml.Load(arquivo);            

            xml.SelectSingleNode("/Contatos").PrependChild(nodeContato);
            xml.SelectSingleNode("/Contatos/Contato").AppendChild(nodeNome);
            xml.SelectSingleNode("/Contatos/Contato").AppendChild(nodeTelefone);

            xml.Save(arquivo);
            ReadAgenda();
        }

        private void ReadAgenda()
        {
            xml.Load(arquivo);
            lblAgenda.Text = "";
            foreach (XmlNode node in xml.SelectNodes("Contatos/Contato"))
            {
                lblAgenda.Text += "Nome: " + node.SelectSingleNode("Nome").InnerText;
                lblAgenda.Text += " Telefone: " + node.SelectSingleNode("Telefone").InnerText;
                lblAgenda.Text += "\n";
            }

        }
    }
}
