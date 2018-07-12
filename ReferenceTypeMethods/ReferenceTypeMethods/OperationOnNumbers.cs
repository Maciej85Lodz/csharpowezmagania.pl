namespace ReferenceTypeMethods
{
    internal class OperationOnNumbers
    {
        public void ChangeQueue(ref int x, ref int y)
        {
            int transient;
            transient = x; // assign the value of the variable x
            x = y;  // assigning the y value in place of the x variable
            y = transient; // assigning the value of x to the variable y
        }

    }
}