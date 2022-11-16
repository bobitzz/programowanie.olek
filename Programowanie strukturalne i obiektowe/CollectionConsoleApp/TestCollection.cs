using System;

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
    }

    class Number
    {
        public int ourNumber;
    }
}
