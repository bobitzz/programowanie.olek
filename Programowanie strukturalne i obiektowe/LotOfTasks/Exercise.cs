using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class Exercise
    {
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

            Console.WriteLine("Wartość wyrażenia a^2 + b^2 to: " + (Math.Pow(a,2) + Math.Pow(b,2)));
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

            Console.WriteLine("Objętość kuli wynosi: " + (1,33 * Math.PI * Math.Pow(radius, 3)));
        }

        public void Exercise8()
        {

        }
    }
}
