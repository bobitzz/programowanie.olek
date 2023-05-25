using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListOfObject
    {
        public void Test()
        {
            List<Person> listOfPeople = new List<Person>();

            Person person = new("Jan", "Kowalski", 10, 170);
            listOfPeople.Add(person);

            listOfPeople.Add(new Person("Ewa", "Nowak", 15, 150));
            listOfPeople.Add(new Person("Paweł", "Niezany", 15, 120));
            listOfPeople.Add(new Person("Bez", "Imienny", 14, 180));

            Console.WriteLine("Lista wszystkich osób");
            foreach (Person p in listOfPeople)
            {
                p.Info();
            }
            Console.WriteLine();

            List<Person> listOfPeoplePegi18;

            listOfPeoplePegi18 = listOfPeople.Where(x => x.age >= 18).ToList();
            Console.WriteLine("Liczba osób pełnoletnich");
            foreach(Person p in listOfPeoplePegi18)
            {
                p.Info();
            }
            Console.WriteLine();

            /*
            select *
            form listOfPeople
            order by age
            */

            List<Person> sortedListByAge = listOfPeople.OrderBy(x => x.age).ToList();
            Console.WriteLine("Liczba osób według wieku");
            foreach (Person p in sortedListByAge)
            {
                p.Info();
            }
            Console.WriteLine();

            List<Person> sortedListByAge2 = listOfPeople.OrderByDescending(x => x.age)
                .ThenBy(x => x.height)
                .ToList();
            Console.WriteLine("Liczba osób według wieku malejąco i wzrostu");
            foreach (Person p in sortedListByAge2)
            {
                p.Info();
            }
            Console.WriteLine();

            List<Person> sortedListByHeight = listOfPeople.OrderBy(x => x.height).ToList();
            Console.WriteLine("Liczba osób według wzrostu");
            foreach (Person p in sortedListByHeight)
            {
                p.Info();
            }
            Console.WriteLine();

            List<Person> sortedListByName = listOfPeople.OrderBy(x => x.name).ToList();
            Console.WriteLine("Liczba osób według imienia");
            foreach (Person p in sortedListByName)
            {
                p.Info();
            }
            Console.WriteLine();

            /*
            List<Person> sortedListByNameNextLetter = listOfPeople.OrderBy(x => x.name).ToList();
            Console.WriteLine("Liczba osób według drugiej litery imienia");
            foreach (Person p in sortedListByNameNextLetter)
            {
                p.Info();
            }
            Console.WriteLine();
            */

            int minAge = listOfPeople.Min(x => x.age);
            Console.WriteLine("Minimalny wzrost to: " + minAge);

            bool isLegalAge = listOfPeople.All(x => x.age < 18);
            Console.WriteLine("Czy wszystkie osoby są niepełnoletnie: " + isLegalAge);
        }
    }
}
