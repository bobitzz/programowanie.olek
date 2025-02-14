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
    }
}
