using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CollectionConsoleApp
{
    class TestCollection
    {
        public void TestArrayCollection()
        {
            /*
                C++:
                typ nazwa[rozmiar];

                int tab[5];
                tab[2] = 21;
            */

            int[] arrayOfNumber = new int[10];
            arrayOfNumber[2] = 32;

            Random random = new Random();
            for (int i = 0; i < arrayOfNumber.Length; i++)
            {
                arrayOfNumber[i] = random.Next() % 100;
                //Console.WriteLine("liczba z tabeli nr: " + i + " to " + arrayOfNumber[i]);
            }

            foreach (int item in arrayOfNumber)
            {
                Console.Write(item + ", ");
            }

            int tmpTheBiggestNumber = arrayOfNumber[0];
            for (int i = 1; i < arrayOfNumber.Length; i++)
            {
                if (tmpTheBiggestNumber < arrayOfNumber[i])
                    tmpTheBiggestNumber = arrayOfNumber[i];
            }
            Console.WriteLine('\n' + "najwieksza liczba to: " + tmpTheBiggestNumber);

            int max = arrayOfNumber[0];
            foreach (int number in arrayOfNumber)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine("najwieksza liczba to: " + max);
        }

        public void TestObjectArrayCollection()
        {
            Number[] arrayWidthObjectNumbers = new Number[5];
            //arrayWidthObjectNumbers[2].ourNumber = 7;
            Random random = new Random();
            for (int i = 0; i < arrayWidthObjectNumbers.Length; i++)
            {
                arrayWidthObjectNumbers[i] = new Number();
                arrayWidthObjectNumbers[i].ourNumber = random.Next() % 100;
            }

            foreach (Number number in arrayWidthObjectNumbers)
            {
                Console.Write($"{number.ourNumber}, ");
            }

            int max = arrayWidthObjectNumbers[0].ourNumber;
            foreach (Number number in arrayWidthObjectNumbers)
            {
                if (number.ourNumber > max)
                    max = number.ourNumber;
            }
            Console.WriteLine("\n" + "najwieksza liczba to: " + max);
        }

        public void TestGeneric()
        {
            Number[] numbers = new Number[5];
            NumberFloat[] floatNumbers = new NumberFloat[5];
            NumberDouble[] doubleNumbers = new NumberDouble[5];

            NumberGeneric<int>[] intGenericNumber = new NumberGeneric<int>[5];
            //intGenericNumber.ourNumber = 7;

            NumberGeneric<int>[] intGenericNumbers = new NumberGeneric<int>[5];
            NumberGeneric<float>[] floatGenericNumbers = new NumberGeneric<float>[5];
            NumberGeneric<double>[] doubleGenericNumbers = new NumberGeneric<double>[5];
            NumberGeneric<byte>[] byteGenericNumbers = new NumberGeneric<byte>[5];

            byteGenericNumbers[2].ourNumber = 7;
        }

        public void ListCollection()
        {
            //int[] tab = mew int[10];
            List<int> listOfInts = new List<int>();
            Console.WriteLine("Kolekcja elementów: " + listOfInts.Count);
            listOfInts.Add(5);
            Console.WriteLine("Kolekcja elementów: " + listOfInts.Count);
            Console.WriteLine("Zerowy element kolekcji: " + listOfInts[0]);
            listOfInts.Add(2137);
            Console.WriteLine("Pierwszy element kolekcji: " + listOfInts[1]); 
        }
    }
}

class Number
{
    public int ourNumber;
}

class NumberFloat
{
    public float ourNumber;
}

class NumberDouble
{
    public double ourNumber;
}

class Number<T>
{
    public T ourNumber;
}

class NumberGeneric<T>
{
    public T ourNumber;
}