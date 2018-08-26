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
        public void Constr()
        {
            WithConstr wc = new WithConstr();
            Console.ReadKey();
        }
        public void ConstrParam()
        {
            string brand = "";
            Console.Write("Please provide the car brand:  ");
            brand = Console.ReadLine();
            ConstrParam cp = new ConstrParam(brand);
            Console.ReadKey();

        }
        public void DeConstr()
        {
            WithDestructor wd = new WithDestructor();
            Console.ReadKey();
        }
        public void StatComp()
        {
            StatsComp sc1 = new StatsComp();
            sc1.Add();
            sc1.Add();
            sc1.Add();
            // Now we will create another StatsComp  type object
            StatsComp sc2 = new StatsComp();
            // Remember that we have only one copy of the static variable
            sc2.Add();
            sc2.Add();
            sc2.Add();
            Console.WriteLine("The value of the number from the first object: {0}", sc1.DisplayNumber());
            Console.WriteLine("The value of the number from the second object: {0}", sc2.DisplayNumber());
            Console.ReadKey();
            // If the result is surprising to you, read again definition of static components
            // Result of the program
            // The value of the number from the first object: 6
            // The value of the number from the second object: 6
        }
        public void StatMeth()
        {
            StatsMeth sm = new StatsMeth();
            sm.Add();
            sm.Add();
            sm.Add();
            // Static method is available without the class object creation
            Console.WriteLine("The value of the number: {0}", StatsMeth.ReturnNumber());
            Console.ReadKey();
            // Wynik działania programu
            //Wartosc liczby: 3

        }
    }
}

