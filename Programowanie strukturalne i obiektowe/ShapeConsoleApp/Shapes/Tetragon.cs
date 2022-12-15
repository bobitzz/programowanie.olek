using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsoleApp.Shapes
{
    class Tetragon
    {
        protected double sideA, sideB, sideC, sideD;
        protected string name;

        public Tetragon(string name, double sideA, double sideB, double sideC, double sideD)
        {
            this.sideA = Math.Abs(sideA);
            this.sideB = Math.Abs(sideB);
            this.sideC = Math.Abs(sideC);
            this.sideD = Math.Abs(sideD);
            this.name = name;
        }

        public double Area()
        {
            return -1;
        }

        public double Perimeter()
        {
            return sideA + sideB + sideC + sideD;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Informacja o czworokącie: " + name);
            Console.WriteLine("Bok a = " + sideA);
            Console.WriteLine("Bok b = " + sideB);
            Console.WriteLine("Bok c = " + sideC);
            Console.WriteLine("Bok d = " + sideD);
            Console.WriteLine("Pole " + Area());
            Console.WriteLine("Obwód " + Perimeter());
            Console.WriteLine();
        }
    }
}
