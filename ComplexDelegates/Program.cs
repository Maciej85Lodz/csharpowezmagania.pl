using System;

namespace ComplexDelegates
{
    delegate int ChangeNumber(int i);
    class Program
    {
        static int number = 5;
        public static int AddNumber(int i)
        {
            number += i;
            return number;
        }
        public static int MultiplyNumber(int i)
        {
            number *= i;
            return number;
        }
        public static int GetNumber()
        {
            return number;
        }
        static void Main(string[] args)
        {
            // Advance delegate instance creation
            ChangeNumber cn;
            // Delegates instance creation
            ChangeNumber cn1 = new ChangeNumber(AddNumber);
            ChangeNumber cn2 = new ChangeNumber(MultiplyNumber);
            cn = cn1;
            cn += cn2;
            // calling the delegate
            cn(5);
            Console.WriteLine("The value of number: {0}", GetNumber());
            Console.ReadKey();
            // Results
            // The value of number: 50
        }
    }
}


