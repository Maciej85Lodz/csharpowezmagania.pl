#define DEBUG 
#define VERSION1 
using System;
namespace Directive {
    class Program
    {
        static void Main(string[] args)
        {
        #if (DEBUG && !VERSION1)
                    Console.WriteLine("DEBUG is defined); "+
        "#elif (!DEBUG && VERSION1) "+
        "Console.WriteLine("VERSION1 is defined); 
        #elif (DEBUG && VERSION1)
                    Console.WriteLine("DEBUG with VERSION1 are defined");
        #else
                    Console.WriteLine("DEBUG with VERSION1 aren't defined");
        #endif
            Console.ReadKey(); 
        }
    }
}