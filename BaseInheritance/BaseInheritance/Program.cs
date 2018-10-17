using System;

namespace BaseInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck d = new Deck(4, 5);
            d.DisplayInformation();
            Console.ReadKey();         
        }
    }
}
