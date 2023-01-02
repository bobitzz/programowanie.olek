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
    }
}
