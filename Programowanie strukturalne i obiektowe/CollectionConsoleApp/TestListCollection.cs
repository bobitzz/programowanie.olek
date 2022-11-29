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

            //int MaxNumberFromInts = MaxFromInts(ListOfInts);
            int MaxNumber = MaxFromAllTypes<int>(ListOfInts);
            Console.WriteLine("Max from ints: " + MaxNumber);

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

            //double MaxNumberFromDoubles = MaxFromDoubles(ListOfDouble);
            double MaxNumberFromDoubles = MaxFromAllTypes<double>(ListOfDouble);
            Console.WriteLine("Max from doubles: " + MaxNumberFromDoubles);
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

        private double MaxFromDoubles(List<double> list)
        {
            double MaxFromDoubles = list[0];
            foreach (double element in list)
            {
                if (element > MaxFromDoubles)
                    MaxFromDoubles = element;
            }
            return MaxFromDoubles;
        }

        private T MaxFromAllTypes<T>(List<T> list)
        {
            T MaxNumber = list[0];
            foreach (T element in list)
            {
                if (element > MaxNumber)
                    MaxNumber = element;
            }
            return MaxNumber;
        }
    }
}
