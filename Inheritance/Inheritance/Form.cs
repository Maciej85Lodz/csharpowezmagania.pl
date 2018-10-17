using System;

namespace Inheritance
{
    //base class
    class Form
    {
        // access modifier protected
        // fields are available for the class and classes that they inherit from it
        
        protected int width;
        protected int height;

        public void SetHeight(int w)
        {
            height = w;
        }
        public void SetWidth(int s)
        {
            width = s;
        }

    }
}
