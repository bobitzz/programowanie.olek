using PeopleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDatabaseClassLibrary
{
    public class PeopleRepository
    {
        private PeopleDBContext dbContext;

        public PeopleRepository()
        {
            dbContext = new PeopleDBContext();
        }

        public void AddNewPerson(string name, string surname, int age)
        {
            Person person = new()
            {
                Name = name,
                Surname = surname,
                Age = age
            };
            dbContext.People.Add(person);
            dbContext.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPeople()
        { 
            /*
             select * from People where Age > 18 order by Surname
            */

            return dbContext
                .People
                .Where(p => p.Age >= 18)
                .OrderBy(p => p.Surname)
                .ThenByDescending(p => p.Name)
                //.select(p => p)
                .ToList();
        }

        public void UpdatePerson(int id, string name, string surname, int age)
        {
            /*
             update people
                set name = nameNET,
                    surname = surnameNET
                    age = ageNET
              where id = idNET
             */


            /*
                select *
                  from people
                 where id = idNET
             */
            //Person personToUpdate = dbContext.People.Where(p=> p.Id == id).FirstOrDefault();
            Person? personToUpdate = dbContext.People.FirstOrDefault(p => p.Id == id);
            if (personToUpdate != null)
            {
                personToUpdate.Name = name;
                personToUpdate.Surname = surname;
                personToUpdate.Age = age;
                dbContext.SaveChanges();
            }
        }
    }
}
