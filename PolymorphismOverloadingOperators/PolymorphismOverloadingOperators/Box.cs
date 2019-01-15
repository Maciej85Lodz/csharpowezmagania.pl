using System;

namespace PolymorphismOverloadingOperators
{
    class Box
    {
        private double length;
        private double width;
        private double height;
        public void GetLength(double l)
        {
            length = l;
        }
        public void GetWidth(double w)
        {
            width = w;
        }
        public void GetHeight(double h)
        {
            height = h;
        }
        public double CalculateVolume()
        {
            return (length * width * height);
        }
        // Operator overload +
        // Adding two types to each other
        public static Box operator +(Box a, Box b)
        {
            Box pud = new Box();
            pud.height = a.height + b.height;
            pud.width = a.width + b.width;
            pud.length = a.length + b.length;
            return pud;

        }
    }
}
