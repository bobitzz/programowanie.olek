using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeConsoleApp.Shapes
{
    class Square : Rectangle
    {
        public Square()
        {
            sideA = sideB = 10;
        }

        public Square(double sideA)
        {
            this.sideA = this.sideB = sideA;
        }

        public new void ShowInfo()
        {
            Console.WriteLine("Informacja o kwadracie");
            Console.WriteLine("Bok a = " + sideA);
            Console.WriteLine("Pole " + Area());
            Console.WriteLine("Obwód " + Perimeter());
            Console.WriteLine();
        }
    }
}
