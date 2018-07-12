using System;


namespace ValuesTypeMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            OperationsOnNumber onl = new OperationsOnNumber();
            int a = 100;
            int b = 200;
            Console.WriteLine("Wartość a przed zamianą: {0}", a);
            Console.WriteLine("Wartość b przed zamianą: {0}", b);
            // Call the reverse order method
            onl.ChangeOrder(a, b);
            Console.WriteLine("Wartość a po zmianie: {0}", a);
            Console.WriteLine("Wartość b po zmianie: {0}", b);
            Console.ReadKey();
            // Result
            // Value a before change: 100 
            // Value b before change: 200 
            // Value after change: 100 
            // Value b after change: 200

        }
    }
}
