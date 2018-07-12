using System;
namespace Methods
{
    public class Recursion
    {
        static void Main(string[] args)
        {
            Factorial fc = new Factorial();
            Console.Write("Factorial of number 6 to : {0}", fc.ComputeFactorial(6));
            Console.ReadKey();
            // The result of the program
            // Factorial of number  6 to : 720
        }
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
          

            public Factorial()
            {
                this.number = number;
            }
        }

    }
}
