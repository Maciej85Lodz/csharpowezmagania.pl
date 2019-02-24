using System;
using System.Dynamic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTransactions dt1 = new DataTransactions("01","23/02/2019",1985);
            DataTransactions dt2 = new DataTransactions("01", "23/02/2019", 17091985);
            dt1.DisplayData();
            dt2.DisplayData();
            Console.ReadKey();
        }
    }
}
