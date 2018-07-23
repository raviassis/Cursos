using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace System.XML_Exemple
{
    public class SContatos
    {
        public static string arquivo = @"D:\Aulas\Agenda.xml";
        public static XmlDocument xml = new XmlDocument();
        public static XElement xE;
        public static Contatos contatos;

        public SContatos()
        {
            if (!File.Exists(arquivo))
            {
                XmlNode nodeRoot = xml.CreateElement("Contatos");
                xml.AppendChild(nodeRoot);
                xml.Save(arquivo);
            }
        }

        public static Contatos Read()
        {
            xE = XElement.Load(arquivo);
            contatos = Serializer.Deserialize<Contatos>(xE);

            return contatos;
        }

        public static void Write(Contatos contatos)
        {
            XElement xER = Serializer.Serialize<Contatos>(contatos);
            xER.Save(arquivo);
        }

    }
}
