using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class GreaterNumber
    {
        public int FindMax(int a, int b)
        {
            // local declaration of returned type
            int score;
            if (a > b)
                score = a;
            else
                score = b;
            return score;
        }

    }
}
