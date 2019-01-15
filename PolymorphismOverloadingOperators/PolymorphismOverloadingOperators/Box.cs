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
        // Przeciążenie operatora ==
        public static bool operator ==(Box a, Box b)
        {
            bool status = false;
            if (a.length == b.length && a.width == b.width && a.height == b.height)
                status = true;
            return status;
        }
        // Przeciążenie operatora !=
        public static bool operator !=(Box a, Box b)
        {
            bool status = false;
            if (a.length != b.length || a.width != b.width || a.height != b.height)
                status = true;
            return status;
        }
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, width, height);
        }
    }
}
