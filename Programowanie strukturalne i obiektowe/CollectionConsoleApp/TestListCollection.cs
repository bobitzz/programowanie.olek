using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListCollection
    {
        public void FirstTest()
        {
            Random random = new Random();

            List<int> ListOfInts = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                ListOfInts.Add(random.Next(1, 11));
            }
            Console.WriteLine("Lista int'ów: ");
            foreach (int element in ListOfInts)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine("\b");

            List<double> ListOfDouble = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                double number = random.NextDouble() * 10 + 1;
                number = Math.Round(number, 4);

                ListOfDouble.Add(number);
            }
            Console.WriteLine("Lista doubl'ów: ");
            foreach (int element in ListOfDouble)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine("\b");

            int MaxNumber = MaxFromInts(ListOfInts);
            Console.WriteLine("Max from ints: " + MaxNumber);
        }

        private int MaxFromInts(List<int> list)
        {
            int MaxNumber = list[0];
            foreach (int element in list)
            {
                if (element > MaxNumber)
                    MaxNumber = element;
            }
            return MaxNumber;
        }
    }
}
