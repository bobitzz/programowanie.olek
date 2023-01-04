using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if(temperature >= 20)
                Console.WriteLine("ciepło");
            else
                Console.WriteLine("zimno");
        }
        #endregion
    }
}
