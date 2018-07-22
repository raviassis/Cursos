using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System.IO_Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("The quick brown fox jumps over the lazy dog");
            File.AppendAllText(@"d:\1.txt", sb.ToString());
        }
    }
}
