using System;
using System.Runtime.CompilerServices;

namespace inf04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a");
            uint numberA = uint.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            uint numberB = uint.Parse(Console.ReadLine());

            Console.WriteLine("NWD: " + NWD(numberA, numberB));
        }

        static uint NWD(uint numberA, uint numberB)
        {
            if (numberA != numberB)
            {
                do
                {
                    if (numberA > numberB)
                        numberA -= numberB;
                    else
                        numberB -= numberA;
                } while (numberA != numberB);
                return numberA;
            }
            else
                return numberA;
        }
    }
}
