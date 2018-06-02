using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class NestingLoops
    {
        /*
         * for(inicjalizacja_1; warunek_1; inkrementacja_1)
            {
                for(inicjalizacja_2; warunek_2; inkrementacja_2)
                {
                    instrukcje_polecen();
                }
                instrukcje_polecen();
            }
         */
        public void Nesting()
        {
            for (int l1 = 0; l1 < 5; l1++)
            {
                for (int l2 = 2; l2 > 0; l2--)
                {
                    Console.WriteLine("Liczba l1 to: {0}, Liczba l2 to : {1}", l1, l2);
                }
            }

            Console.ReadKey();
        }
    }
}
