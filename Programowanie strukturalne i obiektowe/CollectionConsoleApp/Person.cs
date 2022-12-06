using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class Person
    {
        public string name;
        public string surname;
        public int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void Info()
        {
            Console.WriteLine(name + " " + surname + " " + age + " lat");
        }
    }
}