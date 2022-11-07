using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstObjectConsoleApp
{
    class Pearson
    {
        string name, surname;
        int age;

        public Pearson()
        {
            name = "Jan";
            surname = "Nieznany";
            age = 21;
        }

        public Pearson(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
    }
}
