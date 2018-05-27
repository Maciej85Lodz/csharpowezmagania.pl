using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatement
{
    public class IfElseState
    {
        static void Main(string[] args)
        {
            // Deklaracja zmiennych
            int i = 20;
            // Sprawdzenie warunku przy użyciu instrukcji if
            if (i < 45)
            {
                // Kod zostanie wykonany, jeżeli warunek jest spełniony
                Console.WriteLine("Liczba jest mniejsza niż 45");
            }
            else
            {
                Console.WriteLine("Liczba nie jest mniejsza niż 45");
            }

            Console.ReadKey();

        }
    }

}
