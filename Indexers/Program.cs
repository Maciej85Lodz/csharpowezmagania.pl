using System;

namespace Indexers
{
    class Program
    {
        // names list
        private string[] nameList = new string[size];
        // list size
        static int size = 10;

        static void Main(string[] args)
        {
            Program names = new Program();
            names[0] = "BMW";
            names[1] = "Pagani";
            names[2] = "Audi";
            names[3] = "Tesla";
            names[4] = "Porsche";
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }
        // The class constructor fills the list with 'N.A' elements
        public Program()
        {
            for (int i = 0; i < size; i++)
            {
                nameList[i] = "N.A";
            }
        }
        // Indekser
        public string this[int index]
        {
            get
            {
                string temp;
                if (index >= 0 && index <= size - 1)
                    temp = nameList[index];
                else
                    temp = "";
                return temp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                    nameList[index] = value;
            }
        }
    }
}

