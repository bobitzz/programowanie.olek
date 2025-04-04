using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleDatabaseFirstClassLibrary
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Surname { get; set; }

        public int Age { get; set; }
    }
}
