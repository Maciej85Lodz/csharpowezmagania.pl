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
            Console.WriteLine("Value a before switching: {0}", a);
            Console.WriteLine("Value b before switching: {0}", b);
            // Call the reverse order method
            onl.ChangeQueue(ref a, ref b);
            Console.WriteLine("Value a after switching: {0}", a);
            Console.WriteLine("Value b after switching: {0}", b);
            Console.ReadKey();
            // The result of the program 
            // The value before the conversion: 25 
            // The value of b before conversion: 50 
            // The value after the change: 25 
            // The value of b after the change: 50

        }
    }
}
