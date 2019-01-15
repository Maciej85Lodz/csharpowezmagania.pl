using System;

namespace PolimorphismOverLoadingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DataDisplay dd = new DataDisplay();
            dd.Dislay(4);
            dd.Dislay(4.5);
            dd.Dislay("4.5");
            Console.ReadKey();
            
        }
    }
    class DataDisplay
    {
        public void Dislay(int i)
        {
            Console.WriteLine("Displayed number: {0}", i);
        }
        public void Dislay(double d)
        {
            Console.WriteLine("Displayed number: {0}", d);
        }
        public void Dislay(string s)
        {
            Console.WriteLine("Displayed number: {0}", s);
        }
    }
}