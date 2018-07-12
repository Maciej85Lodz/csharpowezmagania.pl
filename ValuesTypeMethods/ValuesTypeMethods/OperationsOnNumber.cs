using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValuesTypeMethods
{
    public class OperationsOnNumber
    {
        public void ChangeOrder(int x, int y)
        {
            int temporary;
            temporary = x; // assigning the value of variable x 
            x = y;  //  assigning the value of y to the variable x
            y = temporary; // assigning the value of variable x to variable y
        }
    }

}

