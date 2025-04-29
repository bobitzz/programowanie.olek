using System.Collections.ObjectModel;
using ToDoClassLibrary;
using ToDoClassLibrary.Models;
using Microsoft.Maui.Controls;

namespace ToDoListMauiApp.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        private readonly TaskRepository taskRepository = new();

        private string taskContent;
        public string TaskContent
        {
            get => taskContent;
            set { taskContent = value; OnPropertyChanged(); }
        }

        public ObservableCollection<Todotask> ActiveTasks { get; set; } = new();
        public ObservableCollection<Todotask> DeletedTasks { get; set; } = new();

        public Command AddTaskCommand { get; }
        public Command<Todotask> MarkTaskAsDeletedCommand { get; }
        public Command<Todotask> MarkTaskAsDoneCommand { get; }

        public MainPageViewModel()
        {
            AddTaskCommand = new Command(AddTask);
            MarkTaskAsDeletedCommand = new Command<Todotask>(MarkTaskAsDeleted);
            MarkTaskAsDoneCommand = new Command<Todotask>(MarkTaskAsDone);

            LoadTasks();
        }

        private void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(TaskContent))
            {
                taskRepository.CreateNewTask(TaskContent);
                TaskContent = string.Empty;
                LoadTasks();
            }
        }

        private void MarkTaskAsDeleted(Todotask task)
        {
            if (task != null)
            {
                taskRepository.MarkTaskAsDeleted(task.Id);
                LoadTasks();
            }
        }

        private void MarkTaskAsDone(Todotask task)
        {
            if (task != null)
            {
                task.IsDone = true;
                taskRepository.SaveChanges(task);
                LoadTasks();
            }
        }

        private void LoadTasks()
        {
            ActiveTasks.Clear();
            foreach (var task in taskRepository.GetActiveTasks().Where(t => !t.IsDone))
            {
                ActiveTasks.Add(task);
            }

            DeletedTasks.Clear();
            foreach (var task in taskRepository.GetDeletedTasks())
            {
                DeletedTasks.Add(task);
            }
        }
    }
}
