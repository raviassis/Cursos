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

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Deserializer
            XElement xE = XElement.Load(arquivo);
            Contatos contatos = Serializer.Deserialize<Contatos>(xE);

            //Serializer
            XElement xER = Serializer.Serialize<Contatos>(contatos);
            
        }
    }
}
