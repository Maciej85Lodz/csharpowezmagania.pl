using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class ForLoop
    /*
    * for(inicjalizacja; warunek; inkrementacja)
      {
        Instrukcja_Poleceń();
       }
     */
    {
        public void Floop()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
