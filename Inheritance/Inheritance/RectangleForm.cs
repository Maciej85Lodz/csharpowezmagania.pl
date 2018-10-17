using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //derived class
    class Rectangle:Form
    {
        public int CalculateSurface()
        {
            //we have access to fields from the base class
            return height * width;
        }

    }
}
