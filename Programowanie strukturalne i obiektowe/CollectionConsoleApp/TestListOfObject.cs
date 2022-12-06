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

            Person person = new("Jan", "Kowalski", 40);
            listOfPeople.Add(person);

            listOfPeople.Add(new Person("Ewa", "Nowak", 36));
            listOfPeople.Add(new Person("Paweł", "Niezany", 15));
            listOfPeople.Add(new Person("Bez", "Imienny", 14));

            Console.WriteLine("Lista wszystkich osób");
            foreach (Person p in listOfPeople)
            {
                p.Info();
            }

            List<Person> listOfPeoplePegi18;

            listOfPeoplePegi18 = listOfPeople.Where(x => x.age >= 18).ToList();
            Console.WriteLine("Liczba osób pełnoletnich");
            foreach(Person p in listOfPeoplePegi18)
            {
                p.Info();
            }
            Console.WriteLine();
        }
    }
}
