﻿using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hello World!");

            int number = 123;

            Console.Write("wartość zmiennej to: ");
            Console.WriteLine(number);

            Console.WriteLine("wartość zmiennej to " + number);
            Console.WriteLine("wartość zmiennej to {number} ");
            Console.WriteLine($"warotść zmiennej to {number} .");

            Console.WriteLine("prędkośc to km\\h");
            //Console.WriteLine("c:\Folder1\Folder2\plik.txt");
            Console.WriteLine(@"c:\Folder1\Folder2\plik.txt");
            Console.WriteLine("c:\\Folder1\\Folder2\\plik.txt");
            Console.WriteLine("c:/Folder1/Folder2/plik.txt");

            // <, >, <=, >=, ==, !=

            double number2 = number;
        }
    }
}