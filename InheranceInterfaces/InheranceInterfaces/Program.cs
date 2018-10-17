using System;

namespace InheranceInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 5);
            Console.WriteLine(r.DisplayLength(r.lenght));
            Console.WriteLine(pr.DisplayWidth(r.width));
            Console.WriteLine("Cena to: {0}", r.CalkulateCost(25));

            Console.ReadKey();            
        }
    }

    // base class
    class Form
    {
        public int lenght;
        public int width;

        public Form(int l, int w)
        {
            lenght = l;
            width = w;
        }

        public int CalkulateSurface()
        {
            return lenght * width;
        }
    }

    // interface definition
    
    public interface CalkulateCost
    {
        int CalkulateCost(int surface);
    }

    public interface DisplayInformation
    {
        string DisplayLenght(int lenght);

        string DisplayWidth(int width);
    }

    class Rectangle : Form, CalkulateCost, DisplayInformation
    {
        public Rectangle(int l, int w) : base(l, w)
        {
        }
        // implementation interface method CalkulateCost
        public int CalkulateCost(int p)
        {
            int cost;
            cost = p * CalkulateSurface();
            return cost;
        }

        // implementation interface method DisplayLenght
        public string DisplayLenght(int lenght)
        {
            string info = String.Format("Lenght is: {0}", lenght);
            return info;
        }

        // implementation interface method DisplayWidth
        public string DisplayWidth(int width)
        {
            string info = String.Format("Szerokość to: {0}", width);
            return info;
        }
    }
}
