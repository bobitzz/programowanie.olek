using SchoolApp.Database;
using SchoolApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.Run();
        }
    }
}
