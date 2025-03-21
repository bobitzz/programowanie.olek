using QuizDatabaseClassLibrary;
using QuizDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDatabaseMauiApp
{
    internal class MainPageViewModel : BindableObject
    {
        public List<Question> Questions { get; set; }

        private string questionText;
        public string QuestionText
        {
            get { return questionText; }
            set { questionText = value; OnPropertyChanged(); }
        }

        private QuizRepository quizRepository;

        public MainPageViewModel()
        {
            quizRepository = new QuizRepository();
        }
    }
}
