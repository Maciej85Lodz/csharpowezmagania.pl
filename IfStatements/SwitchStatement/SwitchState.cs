using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    public class SwitchState
    {
        static void Main(string[] args)
        {
            // Definicja zmiennej lokalnej
            string marka = "Audi";
            switch (marka)
            {
                case "BMW":
                    Console.WriteLine("Wybrałeś samochód marki BMW");
                    break;
                case "Polonez":
                    Console.WriteLine("Wybrałeś samochód marki Porsche");
                    break;
                case "Fiat":
                    Console.WriteLine("Wybrałeś samochód marki Audi");
                    break;
                default:
                    break;
            }

        }
    }

}
