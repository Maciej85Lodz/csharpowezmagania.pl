using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class CommandContinue
    {
        public void ComCon()
        {
            for (int i = 0; i < 5; i++)
            {
                // Jeżeli liczba wyniesie 3 przejdziemy do wykonania kolejnej iteracji
                // kod obecnej iteracji zostanie pominięty
                if (i == 3)
                    continue;
                Console.WriteLine("Liczba i wynosi: {0}", i);
            }
        }
    }
}
