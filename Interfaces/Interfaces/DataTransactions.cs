using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class DataTransactions : IDataTransactions
    {
        private string code;
        private string data;
        private int quantity;

        public DataTransactions(string k, string d, int i)
        {
            code = "";
            data = "";
            quantity = 0;

            code = k;
            data = d;
            quantity = i;
        }

        public int CalculateQuantity()
        {
            return quantity;
        }

        public void DisplayData()
        {
            Console.WriteLine("Code: {0}", code);
            Console.WriteLine("Data:{0}", data);
            Console.WriteLine("Quantity: {0}", quantity);
        }
    }
}
