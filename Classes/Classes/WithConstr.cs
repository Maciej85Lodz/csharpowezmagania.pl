using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class WithConstr
    {
        private string tekst;
        public WithConstr()
        {
            tekst = "Class Constructor calls";
            Console.WriteLine(tekst);
        }
    }
}
