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
            int MaxNumber = MaxFromAllTypes<int>(ListOfInts, CheckInt);
            Console.WriteLine("Max from ints: " + MaxNumber);

            List<double> ListOfDouble = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                double number = random.NextDouble() * 10 + 1;
                number = Math.Round(number, 4);

                ListOfDouble.Add(number);
            }
            Console.WriteLine("Lista doubl'ów: ");
            foreach (double element in ListOfDouble)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine("\b");

            //double MaxNumberFromDoubles = MaxFromDoubles(ListOfDouble);
            double MaxNumberFromDoubles = MaxFromAllTypes<double>(ListOfDouble, CheckDouble);
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

        private T MaxFromAllTypes<T>(List<T> list, Func<T, T, bool> check)
        {
            T MaxNumber = list[0];
            foreach (T item in list)
            {
                if (check(item, MaxNumber))
                    MaxNumber = item;

                /*
                if(item is int)
                {
                    if (CheckInt(int.Parse(item.ToString()), int.Parse(MaxNumber.ToString())))
                        MaxNumber = item;
                }
                if (item is double)
                {
                    if (CheckDouble(double.Parse(item.ToString()), double.Parse(MaxNumber.ToString())))
                        MaxNumber = item;
                }
                */
                /*
                if (item is Person)
                {
                    if (CheckPerson(item as Person, max as Person)
                            MaxNumber = item;
                }
                */
            }
            return MaxNumber;
        }

        private bool CheckInt(int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber;
        }

        private bool CheckDouble(double firstNumber, double secondNumber)
        {
            return firstNumber > secondNumber;
        }

        /*
        private Person CheckPerson(Person firstPerson, secondPerson)
        {
            return firstPerson.age > secondPerson.age;
        }
        */
    }
}
