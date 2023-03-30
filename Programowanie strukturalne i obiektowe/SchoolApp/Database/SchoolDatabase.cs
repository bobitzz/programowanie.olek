using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Database.Entities;

namespace SchoolApp.Database
{
    class SchoolDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=schoolDatbase.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<SchoolClass> SchoolClasses { get; set; }
    }
}