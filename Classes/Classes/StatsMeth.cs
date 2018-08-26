using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class StatsMeth
    {
        public static int number;
        public int number2;
        public void Add()
        {
            number++;
        }
        public static int ReturnNumber()
        {
            // In the method we do not have access to variable number2
            return number;

        }
    }
}
