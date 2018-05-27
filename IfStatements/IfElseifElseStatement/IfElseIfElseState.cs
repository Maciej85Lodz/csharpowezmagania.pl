using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseifElseStatement
{
    public class IfElseIfElseState
    {
        static void Main(string[] args)
        {
            // Definicja zmiennej
            int i = 200;
            // Sprawdzenie warunków przy użyciu instrukcji warunkowej if...else if...else
            if (i == 20)
            {
                // Kod zostanie wykonany, jeżeli warunek jest spełniony
                Console.WriteLine("Liczba jest równa 20");
            }
            else if (i == 40)
            {
                // Kod zostanie wykonany, jeżeli warunek else if jest spełniony
                Console.WriteLine("Liczba jest równa 40");
            }
            else if (i == 60)
            {
                // Kod zostanie wykonany, jeżeli warunek else if jest spełniony
                Console.WriteLine("Liczba jest równa 60");
            }
            else
            {
                // Kod zostanie wykonany, jeżeli żaden powyższy warunek nie jest spełniony
                Console.WriteLine("Żadna z powyższych liczb nie pasuje");
            }

        }
    }
}
