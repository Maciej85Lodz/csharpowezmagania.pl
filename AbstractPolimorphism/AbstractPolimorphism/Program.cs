using System;

namespace AbstractPolimorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Square sq = new Square(4, 5);
            double s = sq.Surface();
            Console.WriteLine("Area of ​​the figure: {0}", s);
            Console.ReadKey();
        }
    }
    abstract class Form
    {
        public abstract int Surface();
    }
    class Square : Form
    {
        // derived class must implement base class methods
        private int height;
        private int width;
        public Square(int a, int b)
        {
            height = a;
            width = b;
        }
        public override int Surface()
        {
            return (height * width);
        }
    }
}

