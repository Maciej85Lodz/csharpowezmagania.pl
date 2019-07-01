using System;

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new first_name_space.namespace_1();
            var p2 = new second_name_space.namespace_2();
            p1.method();
            p2.method();
            Console.ReadKey(); 
            // The result of the program
            // // Inside the first namespace
            // // Inside the second namespace
        }
    }
}

namespace first_name_space
{
    class namespace_1
    {
        public void method()
        {
            Console.WriteLine("Inside first namespace");
        }
    }
}

namespace second_name_space
{
    class namespace_2
    {
        public void method()
        {
            Console.WriteLine("Inside second namespace");
        }
    }
}
