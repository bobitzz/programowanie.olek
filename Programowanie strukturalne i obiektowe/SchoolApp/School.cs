using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Database;
using SchoolApp.Database.Entities;

namespace SchoolApp
{
    class School
    {
        private SchoolDatabase schoolDatabase = new SchoolDatabase();

        public void Run()
        {
            while (true)
            {
                ShowMenu();

                Console.WriteLine("Wybierz: ");
                //int option = int.Parse(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(), out int option))
                    continue;

                switch(option)
                {
                    case 1:
                        AddNewSchoolClass();
                        break;
                    case 2:
                        RemoveSchoolClass();
                        break;
                    case 3:
                        ModifySchoolClass();
                        break;
                    case 4:
                        ShowAllSchoolClasses();
                        break;
                    case 5:
                        AddNewStudent();
                        break;
                    case 8:
                        ShowAllStudents();
                        break;

                    case 0:
                        return;
                }
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Lista dostępnych opcji:");  //CRUD

            Console.WriteLine("1. Dodanie nowej klasy");  //C - create
            Console.WriteLine("2. Usunięcie klasy");  //D - delete
            Console.WriteLine("3. Modyfikacja klasy");  //U - update
            Console.WriteLine("4. Wyświetlenie wszytkich klas");  //R - read
            Console.WriteLine("5. Dodawanie studenta");
            Console.WriteLine("8. Wyświetlanie wszystkich uczniów");
            
            Console.WriteLine("0. Koniec programu");
        }

        #region Metody do pracy na tabeli SchoolClasses

        private void AddNewSchoolClass()
        {
            Console.WriteLine("Podaj nazwe klasy");
            string className = Console.ReadLine();

            SchoolClass schoolClass = new SchoolClass()
            {
                Name = className
            };

            schoolDatabase.SchoolClasses.Add(schoolClass);
            schoolDatabase.SaveChanges();
        }

        private void ShowAllSchoolClasses()
        {
            Console.WriteLine("Wszystkie klasy:");
            foreach (SchoolClass schoolClass in schoolDatabase.SchoolClasses)
            {
                Console.WriteLine(schoolClass.Id + " " + schoolClass.Name);
            }
            Console.ReadKey();
        }

        private void RemoveSchoolClass()
        {
            Console.WriteLine("Podaj id klasy do usunięcia: ");
            if(int.TryParse(Console.ReadLine(), out int idToDeleted))
            {
                SchoolClass schoolClassToDelete = schoolDatabase.SchoolClasses.FirstOrDefault(sc => sc.Id == idToDeleted);
                if (schoolClassToDelete != null)
                {
                    schoolDatabase.SchoolClasses.Remove(schoolClassToDelete);
                    schoolDatabase.SaveChanges();   
                    Console.WriteLine("Kasowanie zakończone sukcesem");
                }
                else
                    Console.WriteLine("Brak klasy w bazie");
            }
            else
                Console.WriteLine("Błąd parsowania. Nieprawidłowa liczba");

            Console.ReadKey();
        }

        private void ModifySchoolClass()
        {
            Console.WriteLine("Podja id klasy do modyfikacji");
            if (int.TryParse(Console.ReadLine(), out int idToModify))
            {
                SchoolClass schoolClassToModify = schoolDatabase.SchoolClasses.FirstOrDefault(sc => sc.Id == idToModify);
                if (schoolClassToModify != null)
                {
                    Console.WriteLine("Podaj nową nazwę klasy");
                    string newName = Console.ReadLine();

                    schoolClassToModify.Name = newName;
                    schoolDatabase.SaveChanges();
                    Console.WriteLine("Modyfikacja zakończone sukcesem");
                }
                else
                    Console.WriteLine("Brak klasy w bazie");
            }
            else
                Console.WriteLine("Błąd parsowania. Nieprawidłowa liczba");

            Console.ReadKey();
        }

        #endregion

        #region Metody do pracy na tabeli Students
        
        private void AddNewStudent()
        {
            Console.WriteLine("Podaj imię:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj id klasy:");
            int schoolClassId = int.Parse(Console.ReadLine());

            Student student = new Student() {
                Name = name,
                Surname = surname,
                SchoolClassId = schoolClassId
            };

            schoolDatabase.Students.Add(student);
            schoolDatabase.SaveChanges();
            Console.WriteLine("Dodano studenta");
            Console.ReadKey();
        }

        private void ShowAllStudents()
        {
            Console.WriteLine("Wszyscy uczniowie:");

            foreach (Student student in schoolDatabase.Students)
            {
                Console.WriteLine("Id " + student.Id);
                Console.WriteLine("Imię " + student.Name);
                Console.WriteLine("Nazwisko " + student.Surname + "\n");
            }
            Console.ReadKey();
        }

        #endregion
    }
}
