using System;
using System.Collections.Generic;
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
            dbContext = new ToDoListDBContext();
        }

        public void CreateNewExercise(string text)
        {
            var newExercise = new List
            {
                Text = text,
                IsDone = false,
                IsDelete = false
            };

            dbContext.Lists.Add(newExercise);
            dbContext.SaveChanges();
        }

        public List getActiveExercise()
        {
            return.db
        }
    }
}
