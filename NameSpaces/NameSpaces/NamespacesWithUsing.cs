using System;
using first_name_space;
using second_name_space;

namespace NameSpaces
{
    class NamespacesWithUsing
    {static void Main(string[] args)
        {
            namespace_1 p1 = new namespace_1();
            namespace_2 p2 = new namespace_2();
            p1.method();
            p2.method();
            Console.ReadKey();
            // The result of the program
            // // Inside the first namespace
            // // Inside the second namespace
        }
    }
}