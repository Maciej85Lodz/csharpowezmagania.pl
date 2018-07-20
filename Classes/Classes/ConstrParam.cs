using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class ConstrParam
    {
        private string brand;
        public ConstrParam(string parameter)
        {
            brand = parameter;
            Console.WriteLine("Brand provided by the user is: {0}", brand);

        }
    }
}
