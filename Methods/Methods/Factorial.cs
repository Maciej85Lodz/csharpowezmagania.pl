using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Factorial
    {
        private int number;

        public int ComputeFactorial(int liczba)
        {
            int score;
            if (number == 1)
                return 1;
            else
            {
                score = ComputeFactorial(number - 1) * number;
                return score;
            }
        }

        public Factorial(int number)
        {
            this.number = number;
        }

        public Factorial()
        {
        }
    }
}
