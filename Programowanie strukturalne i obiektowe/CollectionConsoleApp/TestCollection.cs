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
            Console.WriteLine("najwieksza liczba to: " + tmpTheBiggestNumber);

            int max = arrayOfNumber[0];
            foreach (int number in arrayOfNumber)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine("najwieksza liczba to: " + max);
        }
    }
}
