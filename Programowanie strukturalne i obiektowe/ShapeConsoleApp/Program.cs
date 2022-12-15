using System;
using ShapeConsoleApp.Shapes;

namespace ShapeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new("Prostokąt 1");
            rectangle.ShowInfo();

            Rectangle secondRectangle = new("Prostokąt 2", 54, 99);
            secondRectangle.ShowInfo();

            Square firstSqure = new("Kwadrat ");
            firstSqure.ShowInfo();
        }
    }
}
