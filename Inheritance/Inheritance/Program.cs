using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.SetWidth(4);
            r.SetHeight(5);

            // Calculate surface
            Console.WriteLine("Surface rectangle: {0}", r.CalculateSurface());
            Console.ReadKey();

            // The result of the program
            // Surface rectangle: 20

        }
    }
}
