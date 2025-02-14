using PeopleDatabaseClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDatabaseMauiApp
{
    internal class MainPageViewModel : BindableObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        private Command addPersonCommand;
        public Command AddPersonCommand
        {
            get
            {
                if (addPersonCommand == null)
                    addPersonCommand = new Command(() =>
                    {
                        peopleRepository.AddNewPerson(Name, Surname, Age);
                    });
                return addPersonCommand;
            }
        }

        private PeopleRepository peopleRepository;

    }
}
