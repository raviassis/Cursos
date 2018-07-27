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
        [XmlArray("Telefone")]
        public List<Telefone> Telefone { get; set; }
        [XmlElement("Obs")]
        public string Obs { get; set; }
    }
}
