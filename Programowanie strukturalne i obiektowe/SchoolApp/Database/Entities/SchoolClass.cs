﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    add-migration CreateDatabaseMigration -outputdir Database/Migrations
    update-Database
 */

namespace SchoolApp.Database.Entities
{
    class SchoolClass
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }


}