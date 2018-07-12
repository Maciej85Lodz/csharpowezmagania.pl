using System;

namespace ReferenceTypeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationOnNumbers onl = new OperationOnNumbers();
            int a = 25;
            int b = 50;
            Console.WriteLine("Wartość a przed zamianą: {0}", a);
            Console.WriteLine("Wartość b przed zamianą: {0}", b);
            // Call the reverse order method
            onl.ChangeQueue(ref a, ref b);
            Console.WriteLine("Wartość a po zmianie: {0}", a);
            Console.WriteLine("Wartość b po zmianie: {0}", b);
            Console.ReadKey();
            // The result of the program 
            // The value before the conversion: 25 
            // The value of b before conversion: 50 
            // The value after the change: 25 
            // The value of b after the change: 50

        }
    }
}
