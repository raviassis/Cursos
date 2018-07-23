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
        string arquivo = @"D:\Aulas\Agenda.xml";
        XmlDocument xml = new XmlDocument();
        XElement xE;
        Contatos contatos;

        public Form3()
        {
            InitializeComponent();

            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xml.CreateElement("Contatos");
                xml.AppendChild(nodeRoot);
                xml.Save(arquivo);
            }
                       
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ReadAgenda();
        }

        private void ReadAgenda()
        {
            //Deserializer
            xE = XElement.Load(arquivo);
            contatos = Serializer.Deserialize<Contatos>(xE);
            lblAgenda.Text = string.Empty;
            foreach(Contato contato in contatos.Contato)
            {
                lblAgenda.Text += "Nome: " + contato.Nome + "\nTelefone: " + contato.Telefone + "\n\n";
            }

            //Serializer
            //XElement xER = Serializer.Serialize<Contatos>(contatos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contato c = new Contato();
            c.Id = NextId();
            c.Nome = txtNome.Text;
            c.Telefone = txtTelefone.Text;

            contatos.Contato.Add(c);

            XElement xER = Serializer.Serialize<Contatos>(contatos);
            xER.Save(arquivo);
            ReadAgenda();
        }

        private int NextId()        {

            return (contatos.Contato.Count == 0) ? 1 : contatos.Contato[contatos.Contato.Count - 1].Id + 1;
        }
    }
}
