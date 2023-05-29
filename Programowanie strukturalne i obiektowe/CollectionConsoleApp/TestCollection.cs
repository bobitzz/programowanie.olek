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

            int tab1[5];

            tab1[2] = 2137;

            const int rozmiar = 19;
            //rozmiar = 17;
            int tab2[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {

            }
            */
            int[] arrayOfNumbers = new int[10];
            Console.WriteLine("Kolekcja ma elemenów:" + arrayOfNumbers.Length);
            arrayOfNumbers[5] = 2137;

            Random random = new Random();
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next() % 100;
            }

            /*
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                Console.Write(arrayOfNumbers[i] + ", ");
            }
            */

            Console.WriteLine("Liczby w tablicy:");
            foreach (int item in arrayOfNumbers)
            {
                Console.Write(item + ", ");
                //item = 5;
            }
            Console.WriteLine();

            int max = arrayOfNumbers[0];
            foreach (int number in arrayOfNumbers)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max w tablicy to: " + max);
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
                Console.Write($"{number.ourNumber} ,");
                //number = new Number();
                number.ourNumber = 7;
            }

            int max = arrayWidthObjectNumbers[0].ourNumber;
            foreach (Number number in arrayWidthObjectNumbers)
            {
                if (number.ourNumber > max)
                    max = number.ourNumber;
            }
            Console.WriteLine("Max w tablicy to: " + max);
        }

        public void TestGeneric()
        {
            Number[] numbers = new Number[5];
            NumberFloat[] floatNumbers = new NumberFloat[5];
            NumberDouble[] doubleNumbers = new NumberDouble[5];

            NumberGeneric<int> intGenericNumber = new NumberGeneric<int>();
            intGenericNumber.ourNumber = 7;

            NumberGeneric<int>[] intGenericNumbers = new NumberGeneric<int>[5];
            NumberGeneric<float>[] floatGenericNumbers = new NumberGeneric<float>[5];
            NumberGeneric<double>[] doubleGenericNumbers = new NumberGeneric<double>[5];
            NumberGeneric<byte>[] byteGenericNumbers = new NumberGeneric<byte>[5];

            byteGenericNumbers[2].ourNumber = 7;

            int[] t = new int[5];
            // praca na t 5-elementowa
            int[] tt = new int[10];
            for (int i = 0; i < t.Length; i++)
            {
                tt[i] = t[i];
            }
            t = tt;
            //dalej na t 10-elementowa
        }

        public void ListCollection()
        {
            //int[] tab = new int[10];
            //pracuje na tabilcy
            //tab[4] = 2137;
            List<int> listOfInts = new List<int>();
            Console.WriteLine("Kolekcja ma elemenów:" + listOfInts.Count);
            listOfInts.Add(5);
            Console.WriteLine("Kolekcja ma elemenów:" + listOfInts.Count);
            Console.WriteLine("Zerowy element kolekcji: " + listOfInts[0]);
            listOfInts.Add(2137);
            Console.WriteLine("Pierwszy element kolekcji: " + listOfInts[1]);

            for (int i = 0; i < new Random().Next(1, 100); i++)
            {
                listOfInts.Add(new Random().Next(1, 100));
            }

            for (int i = 0; i < listOfInts.Count; i++)
            {
                //listOfInts[i] = 2;
            }

            foreach (int item in listOfInts)
            {
                Console.WriteLine("Element: " + item);
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

    class NumberGeneric<T>
    {
        public T ourNumber;
    }
}