using PeopleDatabaseClassLibrary;
using PeopleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Person> People { get; set; }

        private Command readPersonCommand;
        public Command ReadPersonCommand
        {
            get
            {
                if (readPersonCommand == null)
                    readPersonCommand = new Command(() =>
                    {
                        List<Person> people = peopleRepository.GetPeople();
                    });
                return readPersonCommand;
            }
        }

        //UPDATE
        private Person currentSelectionPerson;
        public Person CurrentSelectionPerson
        {
            get { return currentSelectionPerson; }
            set { currentSelectionPerson = value; OnPropertyChanged(); }
        }

        private Command updatePersonCommand;
        public Command UpdatePersonCommand
        {
            get
            {
                if (updatePersonCommand == null)
                    updatePersonCommand = new Command(() =>
                    {
                        peopleRepository.UpdatePerson(currentSelectionPerson.Id,
                            currentSelectionPerson.Name,
                            currentSelectionPerson.Surname,
                            currentSelectionPerson.Age);
                    });
                return updatePersonCommand;
            }
        }

        //DELETE
        private Command deletePersonCommand;
        public Command DeletePersonCommand
        {
            get
            {
                if (deletePersonCommand == null)
                    deletePersonCommand = new Command(() =>
                    {
                        if (currentSelectionPerson != null)
                        {
                            peopleRepository.DeletePerson(currentSelectionPerson.Id);

                            People.Remove(currentSelectionPerson);
                        }
                    });
                    return deletePersonCommand;
            }
        }

        private PeopleRepository peopleRepository;
        public MainPageViewModel()
        {
            peopleRepository = new PeopleRepository();
        }
    }
}
