using System;

namespace LotOfTasks
{
    class Exercise
    {
        #region Podstawy programowanie
        public void Exercise1()
        {
            Console.WriteLine("podaj liczbę: ");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę: ");
            float number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Średnia artmetyczna to: " + (number1 + number2) / 2);
        }

        public void Exercise2()
        {
            Console.WriteLine("podaj długość boku: ");
            float side1 = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj długość boku: ");
            float side2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Pole prostokątu wynosi: " + side1 * side2);
        }

        public void Exercise3()
        {
            Console.WriteLine("podaj promień: ");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj wysokość: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Objętość stożka wynosi: " + ((Math.PI) / 3 * Math.Pow(radius, 2) * height));
        }

        public void Exercise4()
        {
            Console.WriteLine("podaj promień: ");
            float radius = float.Parse(Console.ReadLine());

            Console.WriteLine("Pole koła wynosi: " + (Math.PI * Math.Pow(radius, 2)));
        }

        public void Exercise5()
        {
            Console.WriteLine("podaj a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj b: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Wartość wyrażenia a^2 + b^2 to: " + (Math.Pow(a, 2) + Math.Pow(b, 2)));
        }

        public void Exercise6()
        {
            Console.WriteLine("podaj długośc podstawy b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj wysokość: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Pole trójkąta wynosi: " + (b * height) / 2);
        }

        public void Exercise7()
        {
            Console.WriteLine("podaj promień kuli: ");
            float radius = float.Parse(Console.ReadLine());

            Console.WriteLine("Objętość kuli wynosi: " + (1, 33 * Math.PI * Math.Pow(radius, 3)));
        }

        public void Exercise8()
        {
            Console.WriteLine("podaj długośc podstawy a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj długośc podstawy b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("podaj wysokość: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Pole trapezu wynosi: " + ((a + b) * height) / 2);
        }

        public void Exercise9()
        {
            Console.WriteLine("Podaj ocenę wagi 1: ");
            float grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ocenę wagi 2: ");
            float grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ocenę wagi 3: ");
            float grade3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Średnia ważona z ocen wynosi: " + ((grade1 * 1) + (grade2 * 2) + (grade3 * 3)) / 6);
        }
        #endregion-

        #region Instrukcja If
        public void Exercise10()
        {
            Console.WriteLine("Podaj liczbe: ");
            float number = float.Parse(Console.ReadLine());

            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("liczba jest parzysta");
                else
                    Console.WriteLine("liczba jest nieparzysta");
            }
            else
                Console.WriteLine("liczba jest ujemna");
        }

        public void Exercise11()
        {
            Console.WriteLine("Podaj liczbe: ");
            float number = float.Parse(Console.ReadLine());

            if (number > 0)
                Console.WriteLine("liczba jest dodatnia");
            else if (number < 0)
                Console.WriteLine("liczba jest ujemna");
            else
                Console.WriteLine("liczba jest równa 0");
        }

        public void Exercise12()
        {
            Console.WriteLine("Podaj rok: ");
            float year = float.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 != 0)
                        Console.WriteLine("to nie jest rok przestępny");
                    else
                        Console.WriteLine("Rok " + year + " jest przestępny");
                }
                else
                    Console.WriteLine("Rok " + year + " jest przestępny");
            }
            else
                Console.WriteLine("to nie jest rok przestępny");
        }

        public void Exercise13()
        {
            Console.WriteLine("Podaj ocene: ");
            float grade = float.Parse(Console.ReadLine());

            switch (grade)
            {
                case 1:
                    Console.WriteLine("niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("dostateczny");
                    break;
                case 4:
                    Console.WriteLine("dobry");
                    break;
                case 5:
                    Console.WriteLine("bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("celujący");
                    break;
                default:
                    Console.WriteLine("liczba spoza zakresu 1-6");
                    break;
            }
        }

        public void Exercise14()
        {
            string password = "abc123";
            Console.WriteLine("Podaj hasło: ");
            string passwordFromUser = Console.ReadLine();

            if (password != passwordFromUser)
                Console.WriteLine("hasło niepoprawne");
            else
                Console.WriteLine("hasło poprawne");
        }

        public void Exercise15()
        {
            Console.WriteLine("Podaj numer miesiąca: ");
            int month = int.Parse(Console.ReadLine());

            if (month < 1 || month > 12)
                Console.WriteLine("miesiąc spoza zakresu 1-12");
            else
            {
                Console.WriteLine("podaj dzień: ");
                int day = int.Parse(Console.ReadLine());

                if (day < 1 || day > 31)
                    Console.WriteLine("dzień spoza zakresu 1-31");
                else
                {
                    switch (month)
                    {
                        case 1:
                            Console.WriteLine(day <= 31 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 2:
                            Console.WriteLine(day <= 28 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 3:
                            Console.WriteLine(day <= 31 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 4:
                            Console.WriteLine(day <= 30 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 5:
                            Console.WriteLine(day <= 31 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 6:
                            Console.WriteLine(day <= 30 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 7:
                            Console.WriteLine(day <= 31 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 8:
                            Console.WriteLine(day <= 31 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 9:
                            Console.WriteLine(day <= 30 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 10:
                            Console.WriteLine(day <= 31 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 11:
                            Console.WriteLine(day <= 30 ? "poprawna data" : "nieoprawna data");
                            break;
                        case 12:
                            Console.WriteLine(day <= 31 ? "poprawna data" : "nieoprawna data");
                            break;
                    }
                }
            }

        }

        public void Exercise16()
        {
            Console.WriteLine("Podaj temperature: ");
            float temperature = float.Parse(Console.ReadLine());

            if (temperature >= 20)
                Console.WriteLine("ciepło");
            else
                Console.WriteLine("zimno");
        }
        #endregion

        #region Pętle
        public void Exercise17()
        {
            Console.WriteLine("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 2)
                Console.WriteLine("nie jest to liczba pierwsza");
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        Console.WriteLine("nie jest to liczba pierwsza");
                    else
                        Console.WriteLine("to jest liczba pierwsza");
                }
            }
        }

        public void Exercise18()
        {
            Console.WriteLine("Podaj wyraz do sprawdzenia: ");
            string word = Console.ReadLine();
            int length = word.Length;

            if (String.IsNullOrEmpty(word))
                Console.WriteLine("Wyraz \"" + word + "\" nie jest palindromem");
            for (int i = 0; i < length / 2;)
            {
                if (word[i] != word[length - i - 1])
                {
                    Console.WriteLine("Wyraz \"" + word + "\" nie jest palindromem");
                    break;
                }
                else
                {
                    Console.WriteLine("Wyraz \"" + word + "\" jest palindromem");
                    break;
                }
            }
        }

        /*
        public void Exercise19()
        {
            Console.WriteLine("Podaj wyraz do sprawdzenia: ");
            string word = Console.ReadLine();
            Console.WriteLine("Podaj wyraz do sprawdzenia: ");
            string word2 = Console.ReadLine();

            bool IsAnagram(string word, string word2)
            {
                if (word.Length != word2.Length)
                    return false;
                List<char> list1 = word.ToList();
                List<char> list2 = word2.ToList();
                for (int i = 0; i < word.Length; i++)
                    if (!list2.Remove(list1[i])) 
                        return false;
                return true;
            }
            IsAnagram(word, word2);
        }
        */

        public void Exercise20()
        {
            Console.WriteLine("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            int reserveNumber = number;
            int numberLength = number.ToString().Length;
            int amountOfDivider = 1;

            if (reserveNumber < 2)
                Console.WriteLine("nie jest to liczba doskonała");
            else
            {
                for (int i = 2; i <= Math.Sqrt(reserveNumber); i++)
                {
                    if (reserveNumber % i == 0)
                    {
                        amountOfDivider += reserveNumber;
                    }
                }
            }
            if (number != amountOfDivider)
                Console.WriteLine("liczba " + number + " nie jest doskonała");
            else
                Console.WriteLine("liczba " + number + " jest doskonała");

        }

        public void Exercise20v2()
        {
            Console.WriteLine("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            int numberLength = number.ToString().Length;

            int amountOfDivider = 1;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    amountOfDivider += i + number / i;
            }

            if (number == numberLength)
                amountOfDivider -= numberLength;

            if (number == amountOfDivider)
                Console.WriteLine("jest to liczba doskonała");
            else
                Console.WriteLine("nie jest to liczba doskonała ");
        }
        #endregion

        #region Pętla for
        public void Exercise21()
        {
            for (int i = 1; i <= 10; i++)
                Console.Write(i + ", ");
        }

        public void Exercise22()
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine("100 + " + i + " = " + (100 + i));
        }

        public void Exercise23()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("Kwadrat liczby " + i + " wynosi: " + Math.Pow(i, 2));
        }

        public void Exercise24()
        {
            for (int liczba = 1; liczba <= 10; liczba++)
            {
                int aktualnyIloczyn = liczba;
                for (int i = 1; i < liczba; i++)
                {
                    aktualnyIloczyn *= i;
                }
                Console.WriteLine(liczba + "! = " + aktualnyIloczyn);
            }
        }

        public void Exercise25()
        {
            for (int multiplicand = 1; multiplicand <= 9; multiplicand++)
                for (int multiplier = 1; multiplier <= 9; multiplier++)
                    Console.WriteLine(multiplicand + " * " + multiplier + " = " + (multiplicand * multiplier));
        }

        public void Exercise26()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                    Console.Write(i + ", ");
            }
        }
        #endregion
    }
}
