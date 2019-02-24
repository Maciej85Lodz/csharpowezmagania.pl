using System;

namespace PolimorphismVirtualMethods
{
    class rcogram
    {
        static void Main(string[] args)
        {
            CallingClass cc = new CallingClass();
            Rectangle rc = new Rectangle(4, 5);
            Triangle tr = new Triangle(4, 5);
            NoImplementation ni = new NoImplementation(4, 5);
            cc.CallClass(rc);
            cc.CallClass(tr);
            cc.CallClass(ni);
            
            Console.ReadKey();
            
        }
    }
    class Form
    {
        protected int height, width;
        public Form(int a, int b)
        {
            height = a;
            width = b;
        }
        public virtual int Surface()
        {
            Console.WriteLine("Default Surface figure: ");
            return 0;
        }
    }
    class Rectangle : Form
    {
        public Rectangle(int a, int b) : base(a, b)
        {
        }
        public override int Surface()
        {
            Console.WriteLine("Rectangle Surface: ");
            return (height * width);
        }
    }
    class Triangle : Form
    {
        public Triangle(int a, int b) : base(a, b)
        {
        }
        public override int Surface()
        {
            Console.WriteLine("Trangle Surface: ");
            return (height * width) / 2;
        }
    }
    class NoImplementation : Form
    {
        public NoImplementation(int a, int b) : base(a, b)
        {
        }
    }
    
    class CallingClass
    {
        public void CallClass(Form k)
        {
            int a;
            a = k.Surface();
            Console.WriteLine("Surface: {0}", a);
        }
    }
}