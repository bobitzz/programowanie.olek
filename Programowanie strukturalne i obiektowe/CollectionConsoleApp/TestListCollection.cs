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

            //int max = MaxFromInts(ListOfInts);
            //int max = MaxFromAllTypes<int>(ListOfInts, CheckInt);
            int maxFromInts = MaxFromAllTypes<int>(ListOfInts,
                (int firstNumber, int secondNumber) =>
                {
                return firstNumber > secondNumber;
                });
            Console.WriteLine("Max from ints: " + maxFromInts);

            List<int> newListOfInts = GetNewCollection<int>(ListOfInts, x => x > 5);
            Console.WriteLine("Lista intow wiekszych od 5: ");
            foreach (int item in newListOfInts)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

            newListOfInts = GetNewCollection<int>(ListOfInts, x => x % 2 == 0);
            newListOfInts = ListOfInts.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Lista intow parzystych: ");
            foreach (int item in newListOfInts)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();

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

            double maxFromDouble2 = MaxFromAllTypes<double>(ListOfDouble,
                (double firstNumber, double secondNumber) => firstNumber > secondNumber);
            Console.WriteLine("Max from ints: " + maxFromDouble2);
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

        public List<T> GetNewCollection<T>(List<T> list, Func<T, bool> check)
        {
            List<T> newCollection = new List<T>();
            foreach (T item in list)
            {
                if (check(item))
                    newCollection.Add(item);
            }
            return newCollection;
        }

        /*
        public List<int> moreThen(List<int> list)
        {
            List<int> newCollection = new List<int>();
            foreach (int item in list)
            {
                if (item >= 5)
                    newCollection.Add(item);
            }
            return newCollection;
        }
        */

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
