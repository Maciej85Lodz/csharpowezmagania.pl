#define MyVariable;
using System;
namespace Directive {
    class Program {
        static void Main(string[] args)
        {
            #if (MyVariable)
                        Console.WriteLine("Variable is defined");
            #else
                        Console.WriteLine("Variable is not defined"); 
            #endif
                         Console.ReadKey(); 
        }
    }
}