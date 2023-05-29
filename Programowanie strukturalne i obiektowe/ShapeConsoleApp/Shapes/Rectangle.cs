using System;

namespace ShapeConsoleApp.Shapes
{
    class Rectangle : Tetragon
    {
        public Rectangle(string name) : base(name, 21, 37, 21, 37)
        {
        }

        public Rectangle(string name, double sideA, double sideB) : base(name, sideA, sideB, sideA, sideB)
        {

        }

        public override double Area()
        {
            return sideA * sideB;
        }
    }
}
