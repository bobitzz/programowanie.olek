using QuizDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDatabaseClassLibrary
{
    public class QuizRepository
    {
        private QuizDBContext dbContext;

        public QuizRepository()
        {
            dbContext = new QuizDBContext();
        }

        public List<Question> GetQuestions()
        {
            return dbContext.Questions.ToList();
        }
    }
}
