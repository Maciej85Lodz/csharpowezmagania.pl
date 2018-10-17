using System;

namespace BaseInheritance
{
    class Rectangle
    {
        // access modifier protected
        // fields are available for the class and classes that they inherit from it

        protected int width;
        protected int height;

        

        public Rectangle (int w, int s)
        {
            width = w;
            height = s;
        }

        public int CalculateSurface()
        {
            return width * height;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Surface: {0}", CalculateSurface());
        }

    }
}
