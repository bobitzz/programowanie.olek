using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricConsoleApp
{
    public class Point
    {
        private
            int x, y;

        public void Display()
        {
            Console.WriteLine(x.ToString() + ", " + y.ToString());
        }
    }
}
