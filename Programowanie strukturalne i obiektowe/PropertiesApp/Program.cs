using System;

namespace PropertiesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            //person.age = 150598;
            person.SetAge(150598);
            person.SetAge(68);
            person.Age = 45;

            //int age = person.age;
            int age = person.GetAge();
            age = person.Age;

            //person.Surname = "Jan";
            string surname = person.Surname;
            Console.WriteLine(surname.Length);
        }
    }
}
