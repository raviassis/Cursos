using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.XML_Exemple
{
    public class FiltroContatos
    {
        private static List<Contato> filtro;

        public static List<Contato> Filtro {
            get {
                if (filtro == null) filtro = new List<Contato>();
                return filtro;
            }
            set => filtro = value;
        }
    }
}
