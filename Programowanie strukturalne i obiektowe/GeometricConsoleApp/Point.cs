using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricConsoleApp
{
    public class Point
    {
        private int x, y;

        public void Display()
        {
            Console.WriteLine(x.ToString() + ", " + y.ToString());
        }

        //w jezyku c++
        public void SetX(int a)
        {
            if (a > 0)
                x = a;
            else
                throw new ArgumentException("Nie mozna ustawic wartosci ujemnych");
        }

        public int GetX()
        {
            return x;
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 0)
                    y = value;
                else
                    throw new ArgumentException("Nie mozna ustawic wartosci ujemnych");
            }
        }
    }
}
