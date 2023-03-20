using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Database.Entities;

namespace SchoolApp.Database
{
    class SchoolDatabase
    {
        public List<SchoolClass> SchoolClasses { get; set; } = new List<SchoolClass>();
    }
}
