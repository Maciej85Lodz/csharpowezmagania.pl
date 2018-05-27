using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    public class IfState
    {
        static void Main(string[] args)
        {
            // Deklaracja lokalnej zmiennej
            int i = 20;
            int j = 50;
            if (i < j) // Sprawdzenie czy warunek if jest spełniony.
            {
                // Wykonanie blok kodu jeżeli warunek jest spełniony.
                Console.WriteLine("Liczba i jest mniejsza niż Liczba j");
            }
            // Po wykonaniu bloku kodu
            //Program przechodzi do dalszego wykonywania kodu
            Console.ReadKey();
        }
    }
}
