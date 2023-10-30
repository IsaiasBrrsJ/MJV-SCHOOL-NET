using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    public class Forma
    {
        public static string Nome { private get; set; }
        public string RetornaNome()
        {
            return "Forma de bolo";
        }

        private int RetornaTamanho()
        {
            return 10;
        }

        public string Xpto()
        {
            return "";
        }
        public string Xpto(string x)
        {
            return x;
        }
        public string Xpto(string x, int i, string y = "00000")
        {
            var j = 1;
            return x + 1;
        }
    }
}
