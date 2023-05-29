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

            Person person = new Person("Jan", "Kowalski", 10, 170);
            listOfPeople.Add(person);

            listOfPeople.Add(new Person("Ewa", "Nowak", 15, 150));
            listOfPeople.Add(new Person("Paweł", "Nieznany", 15, 120));
            listOfPeople.Add(new Person("Bez", "Imienny", 14, 180));

            Console.WriteLine("Lista wszystkich osób");
            foreach (Person p in listOfPeople)
            {
                p.Info();
            }
            Console.WriteLine();

            List<Person> listofPeoplePegi18;

            /*
             select *
            from listOfPeople
            where age >= 18
             */
            listofPeoplePegi18 = listOfPeople.Where(x => x.age >= 18).ToList();

            Console.WriteLine("Lista osób pełnoletnich");
            foreach (Person p in listofPeoplePegi18)
            {
                p.Info();
            }
            Console.WriteLine();

            //List<Person> sortedListByAge = listOfPeople.OrderBy(x => x.age).ToList();
            List<Person> sortedListByAgeAndHeight = listOfPeople.OrderByDescending(x => x.age)
                .ThenBy(x => x.height)
                //.OrderBy(x => x.height)
                .ToList();
            Console.WriteLine("Lista osób posortowana według wieku malejąco i wzrostu");
            foreach (Person p in sortedListByAgeAndHeight)
            {
                p.Info();
            }
            Console.WriteLine();

            List<Person> sortedListByName = listOfPeople.OrderBy(x => x.name).ToList();
            Console.WriteLine("Lista osób posortowana według imienia");
            foreach (Person p in sortedListByName)
            {
                p.Info();
            }
            Console.WriteLine();

            int age = listOfPeople.Min(x => x.age);
            Console.WriteLine("Najmłotsza osoba ma wiek: " + age);

            bool isLegalAge = listOfPeople.All(x => x.age < 18);
            Console.WriteLine("Czy wszystkie osoby są pełnoletnie " + isLegalAge);
        }
    }
}
