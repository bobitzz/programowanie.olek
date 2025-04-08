using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListClassLibrary.Models;

namespace ToDoListClassLibrary
{
    public class ToDoListRepository
    {
        private ToDoListDBContext dbContext;

        public ToDoListRepository()
        {
            dbContext = new ToDoListDBContext(); ;
        }

        public void AddNewElementToTheList(string text)
        {
            List list = new()
            {
                Text = text
            };
            dbContext.Lists.Add(list);
            dbContext.SaveChanges();
        }
    }
}
