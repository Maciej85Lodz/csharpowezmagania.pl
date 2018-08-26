using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class WithDestructor
    {
        private int number;
        // Constructor
        public WithDestructor()
        {
            Console.WriteLine("The object is created");
        }
        // destructor
        ~WithDestructor()
        {
            Console.WriteLine("The object is deleted");
        }
        public void GetNumber()
        {
            number = 100;
        }
        public void DisplayNumber()
        {
            Console.WriteLine("Number: {0}", number);
        }
    }

}
