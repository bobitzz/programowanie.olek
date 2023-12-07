using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionConsoleApp
{
    public class Fraction
    {
        private int numerator;     //licznik
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        private int denominator;    //mianownik
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                    denominator = value;
                else
                    throw new ArgumentException("mianownik nie może by ujemny");
            }
        }

        public Fraction(int n, int d)
        {
            Numerator = n;
            Denominator = d;
        }

        public Fraction()
        {
            numerator = 0;
            denominator = 1;
        }
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }

        public void Mul(Fraction firstFraction, Fraction secondFraction)
        {
            Numerator = firstFraction.Numerator * secondFraction.Numerator;
            Denominator = firstFraction.Denominator * secondFraction.Denominator;
        }

        public Fraction Mul(Fraction secondFraction)
        {
            Fraction fraction = new Fraction();
            fraction.Mul(this, secondFraction);
            return fraction;
        }

        public 
    }
}