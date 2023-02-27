using System;

namespace PropertiesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new();

            person.SetAge(24);
            int age = person.GetAge();  
        }
    }
}
