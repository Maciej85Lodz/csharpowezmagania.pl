using System;

namespace PolymorphismOverloadingOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = 0;
            Box b1 = new Box();
            Box b2 = new Box();
            Box b3 = new Box();
            // specification 1
            b1.GetLength(3.5);
            b1.GetWidth(4.0);
            b1.GetHeight(5.5);
            // specification 2
            b2.GetLength(2.5);
            b2.GetWidth(5.0);
            b2.GetHeight(4.5);
            // specification 3
            b3.GetLength(12.5);
            b3.GetWidth(15.0);
            b3.GetHeight(14.5);
            // Displaying data inside subsequent objects
            Console.WriteLine("Box 1: {0}", b1.ToString());
            Console.WriteLine("Box 2: {0}", b2.ToString());
            Console.WriteLine("Box 3: {0}", b3.ToString());
            // volume 1
            volume = b1.CalculateVolume();
            Console.WriteLine("Volume 1: {0}", volume);
            // volume 2
            volume = b2.CalculateVolume();
            Console.WriteLine("Volume 2: {0}", volume);
            // Adding 2 objects
            b3 = b1 + b2;
            // volume 3
            volume = b3.CalculateVolume();
            Console.WriteLine("Volume 3: {0}", volume);
            Console.ReadKey();
            // comparison of objects
            if (b1 == b2)
                Console.WriteLine("Pudełka p1 oraz p2 są identyczne");
            if (b1 != b2)
                Console.WriteLine("Pudełka p1 oraz p2 są różne");
            Console.ReadKey();

        }
    }
}
