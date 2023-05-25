using System;

namespace ExceptionApp
{
    class Program
    {
        static int Divide(int a, int b)
        {
            int w = 0;
            if (b != 0)
                w = a / b;
            return w;
        }

        static void Main(string[] args)
        {
            try
            {
                int firstNumber, secondNumber, divNumber;

                Console.WriteLine("Podaj pierwszą liczbę");
                firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj drugą liczbę");
                secondNumber = int.Parse(Console.ReadLine());

                divNumber = firstNumber / secondNumber;
                //divNumber = Divide(firstNumber, secondNumber);

                Console.WriteLine("Wynik dzielenia " + divNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}