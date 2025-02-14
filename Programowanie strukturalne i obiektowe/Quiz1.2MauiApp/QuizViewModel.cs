using Quiz1._2MauiApp;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Quiz1._2MauiApp;
public class QuizViewModel : INotifyPropertyChanged
{
    private int _currentQuestionIndex;
    private string _resultMessage;

    public ObservableCollection<Question> Questions { get; set; }
    public Question CurrentQuestion => Questions[_currentQuestionIndex];

    public string ResultMessage
    {
        get => _resultMessage;
        set
        {
            _resultMessage = value;
            OnPropertyChanged();
        }
    }

    public ICommand NextQuestionCommand { get; }
    public ICommand PreviousQuestionCommand { get; }
    public ICommand CheckAnswersCommand { get; }
    public ICommand ResetQuizCommand { get; }

    public event PropertyChangedEventHandler PropertyChanged;

    public QuizViewModel()
    {
        Questions = new ObservableCollection<Question>
        {
            new Question
            {
                Text = "Jaki kolor ma trawa?",
                Answers = new List<Answer>
                {
                    new Answer { Text = "Czerwony", IsCorrect = false },
                    new Answer { Text = "Niebieski", IsCorrect = false },
                    new Answer { Text = "Zielony", IsCorrect = true },
                    new Answer { Text = "Żółty", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Ile to 2 + 2?",
                Answers = new List<Answer>
                {
                    new Answer { Text = "3", IsCorrect = false },
                    new Answer { Text = "4", IsCorrect = true },
                    new Answer { Text = "5", IsCorrect = false },
                    new Answer { Text = "6", IsCorrect = false }
                }
            },
            new Question
            {
                Text = "Które z tych zwierząt potrafi latać?",
                Answers = new List<Answer>
                {
                    new Answer { Text = "Orzeł", IsCorrect = true },
                    new Answer { Text = "Lew", IsCorrect = false },
                    new Answer { Text = "Słoń", IsCorrect = false },
                    new Answer { Text = "Wróbel", IsCorrect = true }
                }
            },
            new Question
            {
                Text = "Co pijemy na śniadanie?",
                Answers = new List<Answer>
                {
                    new Answer { Text = "Mleko", IsCorrect = true },
                    new Answer { Text = "Zupę pomidorową", IsCorrect = false },
                    new Answer { Text = "Herbata", IsCorrect = true },
                    new Answer { Text = "Makaron", IsCorrect = false }
                }
            }
        };

        _currentQuestionIndex = 0;

        NextQuestionCommand = new Command(NextQuestion);
        PreviousQuestionCommand = new Command(PreviousQuestion);
        CheckAnswersCommand = new Command(CheckAnswers);
        ResetQuizCommand = new Command(ResetQuiz);
    }

    public void NextQuestion()
    {
        if (_currentQuestionIndex < Questions.Count - 1)
        {
            _currentQuestionIndex++;
            OnPropertyChanged(nameof(CurrentQuestion));
        }
    }

    public void PreviousQuestion()
    {
        if (_currentQuestionIndex > 0)
        {
            _currentQuestionIndex--;
            OnPropertyChanged(nameof(CurrentQuestion));
        }
    }

    public void CheckAnswers()
    {
        int correctAnswers = 0;

        foreach (var question in Questions)
        {
            bool allCorrect = question.Answers
                .Where(a => a.IsCorrect)
                .All(a => a.IsSelected);

            bool noneIncorrect = question.Answers
                .Where(a => !a.IsCorrect)
                .All(a => !a.IsSelected);

            if (allCorrect && noneIncorrect)
                correctAnswers++;
        }

        ResultMessage = $"Twój wynik: {correctAnswers}/{Questions.Count}";
    }

    public void ResetQuiz()
    {
        foreach (var question in Questions)
        {
            foreach (var answer in question.Answers)
            {
                answer.IsSelected = false;
            }
        }

        _currentQuestionIndex = 0;
        ResultMessage = string.Empty;
        OnPropertyChanged(nameof(CurrentQuestion));
    }

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}