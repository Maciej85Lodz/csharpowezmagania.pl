using Classes;
using System;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Crate crate1 = new Crate(); // definition of object1 a type Crate 
            Crate crate2 = new Crate(); // definition of object2 a type Crate
            // object1 attributes
            crate1.SetLength(7.5);
            crate1.SetHeight(5.0);
            crate1.SetWidth(3.2);
            // object2 attributes
            crate2.SetLength(6.5);
            crate2.SetHeight(3.4);
            crate2.SetWidth(7.2);
            // capacity of object1
            double cap1 = crate1.CalculateCapacity();
            Console.WriteLine("Capacity of Crate1 is: {0}", cap1);
            // capacity of object2
            double cap2 = crate2.CalculateCapacity();
            Console.WriteLine("Capacity of Crate2 is: {0}", cap2);

            Console.ReadKey();
            // Program results
            //Capacity of Crate1 is: 120
            //Capacity of Crate2 is: 159,12
        }
    }
    class Crate
    {
        public double length; // field available only from the inside of the class
        public double height; // field available only from the inside of the class
        public double width; // field available only from the inside of the class
        // define methods that have access to these fields and are public
        public void SetLength(double len)
        {
            length = len;
        }
        public void SetHeight(double hei)
        {
            height = hei;
        }
        public void SetWidth(double wid)
        {
            width = wid;
        }
        // Method for calculating capacity in a different form than in the first example
        // Class members have their values ​​already, we can calculate the volume
        public double CalculateCapacity()
        {
            return length * height * width;
        }
        static void Constr()
        {
            WithConstr wc = new WithConstr();
            Console.ReadKey();
        }
        static void ConstrParam()
        {
            string brand = "";
            Console.Write("Please provide the car brand:  ");
            brand = Console.ReadLine();
            ConstrParam cp = new ConstrParam(brand);
            Console.ReadKey();

        }
    }
}

