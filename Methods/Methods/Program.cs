using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definition of local variable
            int a = 23;
            int b = 212;
            int score_comarision;
            GreaterNumber wbl = new GreaterNumber();
            score_comarision = wbl.FindMax(a, b);
            Console.WriteLine("Greater number is: {0}", score_comarision);
            Console.ReadKey();

        }
    }
}
