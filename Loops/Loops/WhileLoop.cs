using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class WhileLoop
    {
        /*(while(warunek)
        {
            przykladowe_polecenie();
        }
        */
    static void Main(string[] args)
        {
            int a = 1;
            while (a <= 9)
            {
                Console.WriteLine("Liczba to: {0}", a);
                // Operator inkrementacji, wartość zostaje zwiększona o jeden
                a++;
            }
            Console.ReadKey();
        }
    }
}
