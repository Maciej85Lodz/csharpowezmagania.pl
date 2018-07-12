using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputTypeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationOnNumbers oon = new OperationOnNumbers();
            int a = 350;
            Console.WriteLine("The number before calling the method: {0}", a);
            // Calling the method
            oon.DownloadValue(out a);
            Console.WriteLine("The number after calling the method: {0}", a);
            Console.ReadKey();
            // The result of the program 
            // Number before calling the method: 350 
            // Number after calling the method: 45
        }
    }
}
