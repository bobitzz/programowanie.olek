using Microsoft.EntityFrameworkCore;
using SchoolApp.Database;
using SchoolApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                Console.WriteLine("Wybierz:");
                if (!int.TryParse(Console.ReadLine(), out int option))
                    continue;

                switch (option)
                {
                    case 1:
                        AddNewSchoolClass();
                        break;
                    case 2:
                        DeleteSchoolClass();
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
                    case 6:
                        DeleteStudent();
                        break;
                    case 7:
                        ModifyStudent();
                        break;
                    case 8:
                        ShowAllStudents();
                        break;
                    case 9:
                        ShowAllStudentWithClass();
                        break;
                    case 0:
                        return;
                }
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Lista dostepnych opcji:");
            //CRUD
            Console.WriteLine("1. Dodanie nowej klasy."); //C - create
            Console.WriteLine("2. Usunięcie klasy.");   //D - delete
            Console.WriteLine("3. Modyfikacja klasy."); //U - update
            Console.WriteLine("4. Wyświetlenie wszystkich klas."); //R - read

            Console.WriteLine("5. Dodanie nowego ucznia");
            Console.WriteLine("6. Usunięcie ucznia");
            Console.WriteLine("7. Modyfikacja ucznia");
            Console.WriteLine("8. Wyświetlenie wszystkich uczniów");
            Console.WriteLine("9. Wyświetlenie wszystkich uczniów z informacją o klasie");
            Console.WriteLine("10. Wyświetlenie wszystkich uczniów posortowanych po nazwisku");
            Console.WriteLine("11. Wyświetlenie uczniów z różnymi warunkami");

            Console.WriteLine("0. Koniec programu.");
        }

        #region Metody do pracy na tabeli SchoolClasses

        private void AddNewSchoolClass()
        {
            Console.WriteLine("Podaj nazwę klasy");
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
            /*
             select *
               from SchoolClasses
            */
            foreach (SchoolClass schoolClass in schoolDatabase.SchoolClasses)
            {
                Console.WriteLine(schoolClass.Id + " " + schoolClass.Name);
            }
            Console.ReadKey();
        }

        private void DeleteSchoolClass()
        {
            Console.WriteLine("Podaj id klasy do usunięcia");
            if (int.TryParse(Console.ReadLine(), out int idToDeleted))
            {
                /*
                 delete SchoolClasses
                  where id = idToDeleted
                 */

                /*
                 select *
                   from SchoolClasses
                  where id = idToDeleted
                 */
                SchoolClass schoolClassToDeleted = schoolDatabase
                                                    .SchoolClasses
                                                    .FirstOrDefault(sc => sc.Id == idToDeleted);
                if (schoolClassToDeleted != null)
                {
                    schoolDatabase.SchoolClasses.Remove(schoolClassToDeleted);
                    schoolDatabase.SaveChanges();
                    Console.WriteLine("Kasowanie zakończone sukcesem.");
                }
                else
                {
                    Console.WriteLine("Brak klasy w bazie to takim id");
                }
            }
            else
            {
                Console.WriteLine("Błąd parsowania. Nieprawidłowe dane.");
            }
            Console.ReadKey();
        }

        private void ModifySchoolClass()
        {
            Console.WriteLine("Podaj id klasy do modyfikacji");
            if (int.TryParse(Console.ReadLine(), out int idToModify))
            {
                SchoolClass schoolClassToModify = schoolDatabase
                                                    .SchoolClasses
                                                    .FirstOrDefault(sc => sc.Id == idToModify);
                if (schoolClassToModify != null)
                {
                    Console.WriteLine("Podaj nową nazwę klasy");
                    string newName = Console.ReadLine();

                    schoolClassToModify.Name = newName;
                    schoolDatabase.SaveChanges();
                    /*
                     update set Name =  newName
                    from schoolClassToModify
                    where id =idToModify
                     */
                    Console.WriteLine("Modyfikacja zakończona sukcesem.");
                }
                else
                {
                    Console.WriteLine("Brak klasy w bazie to takim id");
                }
            }
            else
            {
                Console.WriteLine("Błąd parsowania. Nieprawidłowe dane.");
            }
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

            Student student = new Student()
            {
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
            /*
             select *
               from Students
             */
            Console.WriteLine("Lista uczniów");

            foreach (Student student in schoolDatabase.Students)
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
            }
            Console.ReadKey();
        }

        private void ShowAllStudentWithClass()
        {
            /*
             select *
               from Students s, SchoolClasses sc
              where s.SchoolClassId = sc.Id
            
            select *
              from Student s
              join SchoolClasses sc on sc.Id = s.SchoolClassId

             */
            Console.WriteLine("Lista uczniów");

            foreach (Student student in schoolDatabase.Students.Include(s => s.SchoolClass))
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
                Console.WriteLine("Nazwa klasy: " + student.SchoolClass.Name);
            }
            Console.ReadKey();
        }

        private void DeleteStudent()
        {
            Console.WriteLine("Podaj id ucznia do usunięcia");
            int studentId = int.Parse(Console.ReadLine());

            Student studentToDelete = schoolDatabase
                                        .Students
                                        .FirstOrDefault(s => s.Id == studentId);
            if (studentToDelete != null)
            {
                schoolDatabase.Students.Remove(studentToDelete);
                schoolDatabase.SaveChanges();
            }
            else
            {
                Console.WriteLine("Brak ucznia w bazie");
            }
            Console.ReadKey();
        }

        private void ModifyStudent()
        {
            Console.WriteLine("Podaj id ucznia do modyfikacji");
            int studentId = int.Parse(Console.ReadLine());

            Student studentToModify = schoolDatabase
                                        .Students
                                        .FirstOrDefault(s => s.Id == studentId);
            if (studentToModify != null)
            {
                Console.WriteLine("Podaj nowe imię:");
                studentToModify.Name = Console.ReadLine();
                Console.WriteLine("Podaj nowe nazwisko:");
                studentToModify.Surname = Console.ReadLine();

                schoolDatabase.SaveChanges();
            }
            else
            {
                Console.WriteLine("Brak ucznia w bazie");
            }
            Console.ReadKey();
        }

        private void ShowAllStudentsOrderBySurname()
        {
            /*
             select *
               from Students
           order by surname, name dsc
             */
            Console.WriteLine("Lista uczniów");

            foreach (Student student in schoolDatabase.Students.OrderBy(s => s.Surname).ThenByDescending(s => s.Name))
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
            }
            Console.ReadKey();
        }

        private void ShowStudents()
        {
            /*
             select *
               from Students
              where name = "Adam"
                and surname like 'B%'
                and surname like '%now%'
            group by name
            order by surname
             */

            Console.WriteLine("Lista uczniów");

            foreach (Student student in schoolDatabase.Students.Where(s => s.Name == "Adam" 
                                                                           && s.Surname.StartsWith("B")
                                                                           && s.Surname.Contains("now")))
            {
                Console.WriteLine("Id: " + student.Id);
                Console.WriteLine("Imię: " + student.Name);
                Console.WriteLine("Nazwisko: " + student.Surname);
            }
            Console.ReadKey();
        }

        #endregion
    }
}
/*
 * 
  select count(*)
    from Students

  select name, count(*)
    from Students
   where surname = 'nowak'
group by name
having by count(*) >= 3
*/