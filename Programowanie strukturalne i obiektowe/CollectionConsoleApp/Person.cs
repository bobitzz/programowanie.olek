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
        public int height;

        public Person(string name, string surname, int age, int height)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.height = height;
        }

        public void Info()
        {
            Console.WriteLine(name + " " + surname + " " + age + " lat " + height + "cm");
        }
    }
}
