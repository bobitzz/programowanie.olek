using Microsoft.EntityFrameworkCore;
using ToDoClassLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoClassLibrary
{
    public class TaskRepository
    {
        private readonly ToDoDBContext dbContext;

        public TaskRepository()
        {
            dbContext = new ToDoDBContext();
        }

        public void CreateNewTask(string content)
        {
            var newTask = new Todotask
            {
                Content = content,
                IsDone = false,
                IsDeleted = false
            };

            dbContext.Todotasks.Add(newTask);
            dbContext.SaveChanges();
        }

        public List<Todotask> GetActiveTasks()
        {
            return dbContext.Todotasks.Where(predicate: t => !t.IsDeleted).ToList();
        }

        public List<Todotask> GetDeletedTasks()
        {
            return dbContext.Todotasks.Where(t => t.IsDeleted).ToList();
        }

        public void MarkTaskAsDeleted(int taskId)
        {
            var task = dbContext.Todotasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                task.IsDeleted = true;
                dbContext.SaveChanges();
            }
        }

        public void SaveChanges(Todotask task)
        {
            dbContext.Todotasks.Update(task);
            dbContext.SaveChanges();
        }
    }
}
