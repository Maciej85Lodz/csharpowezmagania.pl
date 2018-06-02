using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class DoWhileLoop
    {
        /*
         * do
            {
             instrukcje_polecen();
            }
            while(warunek)
         */
        public void DWloop()
        {
            int i = 3;
            do
            {
                Console.WriteLine("Liczba to: {0}", i);
                i++;
            }
            while (i < 10);
        }
    }
}
