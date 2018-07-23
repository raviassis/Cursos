using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace System.XML_Exemple
{
    [Serializable()]
    public class Contato
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Nome")]
        public string Nome { get; set; }
        [XmlElement("Telefone")]
        public string Telefone { get; set; }
    }
}
