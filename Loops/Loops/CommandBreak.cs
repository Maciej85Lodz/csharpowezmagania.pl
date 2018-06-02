using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class CommandBreak
    {
        public void BrCom()
        {
            for (int i = 0; i < 20; i++)
            {
                // Przerwanie wykonywania pętli gdy liczba jest większa niż 5
                if (i > 5)
                    break;
            }
        }
        
    }
}
