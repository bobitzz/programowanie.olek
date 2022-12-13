using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsoleApp.Shapes
{
    class Rectangle
    {
        protected double sideA, sideB;

        public Rectangle()
        {
            sideA = 21;
            sideB = 37;
        }

        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        double Area()
        {
            return sideA * sideB;
        }

        public double Perimeter()
        {
            return 2 * sideA + 2 * sideB;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Informacja o prostokącie");
            Console.WriteLine("Bok a = " + sideA);
            Console.WriteLine("Bok b = " + sideB);
            Console.WriteLine("Pole " + Area());
            Console.WriteLine("Obwód " + Perimeter());
            Console.WriteLine();
        }
    }
}
