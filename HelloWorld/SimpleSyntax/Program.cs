using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat p = new Prostokat();
            p.SetSides();
            p.ShowResults();
            Console.ReadKey();
        }
        class Prostokat
        {
            private double lengthSideA; //parametr określający długość jednego z boków
            private double lengthSideB; //parametr określający długość drugiego z boków
            

            
            //Metoda powalająca na wprowadzanie wartości boków prostokąta

            public void SetSides()
            {
                //metoda która podaje nam wartości boków prostokata
                private lengthSideA = 5;
                private lengthSideB = 8;

            }
            public void TakeData()
            {
                Console.WriteLine("Podaj szerokość: ");
                lengthSideA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj wysokość: ");
                lengthSideB = Convert.ToDouble(Console.ReadLine());
            }
            double Circuit()
            {
                //obliczanie obwodu prostokata
                return (2 * lengthSideA) + (2 * lengthSideB);
            }

            private double SurfaceArea()
            // Obliczanie Pola Prostokata
            {
                return lengthSideA * lengthSideB;
            }

            public void ShowResults()
            {
                Console.WriteLine("Lenght side A: {0},", lengthSideA);
                Console.WriteLine("Lenght side B: {0},", lengthSideB);
                Console.WriteLine("Circuit: {0},", Circuit());
                Console.WriteLine("Surface Area: {0},", SurfaceArea());
            }
        }

    }
}
