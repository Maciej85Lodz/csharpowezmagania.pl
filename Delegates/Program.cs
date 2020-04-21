using System;

namespace Delegates
{
    class Program
    {
        delegate int ChangeNumber(int i);
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
        static void Main()
        {
            //Delegate instance creation
            ChangeNumber cn1 = new ChangeNumber(AddNumber);
            ChangeNumber cn2 = new ChangeNumber(MultiplyNumber);
            // calling method using the delegates.

            cn1(5);
            Console.WriteLine("The value of number: {0}", GetNumber());
            cn2(10);
            Console.WriteLine("The value of number: {0}", GetNumber());
            Console.ReadKey();
            // Results
            // The value of number: 10
            // The value of number: 100
        }
    }
}
