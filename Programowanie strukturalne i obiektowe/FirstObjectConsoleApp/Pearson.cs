using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstObjectConsoleApp
{
    class Person
    {
        string name, surname;
        int age;

        public Person()
        {
            name = "Jan";
            surname = "Nieznany";
            age = 21;
        }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Informacje o osobie: ");
            Console.WriteLine($"Imie: {name}");
            Console.WriteLine($"Nazwisko: {surname}");
            Console.WriteLine($"Wiek: {age}");
        }
    }
}
