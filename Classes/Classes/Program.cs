using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Crate crate1 = new Crate(); // definition of object1 a type Crate 
            Crate crate2 = new Crate(); // definition of object2 a type Crate
            // object1 attributes
            crate1.length = 7.2;
            crate1.height = 5.6;
            crate1.width = 4.8;
            // object2 attributes
            crate2.length = 4.2;
            crate2.height = 5.8;
            crate2.width = 3.6;
            // capacity of object1
            double cap1 = crate1.CalculateCapacity(crate1.length, crate1.height, crate1.width);
            Console.WriteLine("Capacity of Crate1 is: {0}", cap1);
            // capacity of object1
            // Calculating the capacity of object2 without above method
            double cap2 = crate2.length * crate2.height * crate2.width;
            Console.WriteLine("Capacity of Crate2 is: {0}", cap2);
            Console.ReadKey();
            // Program results
            //Capacity of Crate1 is: 193,536
            //Capacity of Crate2 is: 87,696

        }
        class Crate
        {
            public double length;
            public double height;
            public double width;
            // Method to calculate the capacity define as part of the class
            public double CalculateCapacity(double len, double hei, double wid)
            {
                return len * hei * wid;
            }
        }

    }
}
