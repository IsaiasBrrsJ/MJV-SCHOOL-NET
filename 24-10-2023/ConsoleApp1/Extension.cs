using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MinhaExcecaoPersonalizada : Exception
    {
        public MinhaExcecaoPersonalizada()
        {
        }

        public MinhaExcecaoPersonalizada(string message)
            : base(message)
        {
        }

        public MinhaExcecaoPersonalizada(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
