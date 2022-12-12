using System;
using ShapeConsoleApp.Shapes;

namespace ShapeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new();
            rectangle.ShowInfo();

            Rectangle secondRectangle = new Rectangle(54, 99);
            secondRectangle.ShowInfo();
        }
    }
}
