using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
namespace Quiz2MauiApp;
public class QuizViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private int _currentQuestionIndex;
    private string _questionText;
    private ObservableCollection<AnswerOption> _answerOptions;
    private string _resultMessage;

    public QuizViewModel()
    {
        _currentQuestionIndex = 0;
        LoadQuestions();

        PreviousCommand = new Command(PreviousQuestion, () => _currentQuestionIndex > 0);
        NextCommand = new Command(NextQuestion, () => _currentQuestionIndex < _questions.Count - 1);
        CheckCommand = new Command(CheckAnswer);
        RestartCommand = new Command(RestartQuiz);

        LoadCurrentQuestion();
    }

    private List<Question> _questions;

    public string QuestionText
    {
        get => _questionText;
        set { _questionText = value; OnPropertyChanged(nameof(QuestionText)); }
    }

    public ObservableCollection<AnswerOption> AnswerOptions
    {
        get => _answerOptions;
        set { _answerOptions = value; OnPropertyChanged(nameof(AnswerOptions)); }
    }

    public string ResultMessage
    {
        get => _resultMessage;
        set { _resultMessage = value; OnPropertyChanged(nameof(ResultMessage)); }
    }

    public ICommand PreviousCommand { get; }
    public ICommand NextCommand { get; }
    public ICommand CheckCommand { get; }
    public ICommand RestartCommand { get; }

    private void LoadQuestions()
    {
        _questions = new List<Question>
        {
            new Question("Jaki kolor ma niebo w słoneczny dzień?", new[] { "Niebieski", "Czerwony", "Zielony", "Żółty" }, 0),
            new Question("Ile to 2 + 2?", new[] { "3", "4", "5", "6" }, 1),
            new Question("Co jest większe: słoń czy mysz?", new[] { "Mysz", "Słoń", "Są równe", "Nie wiem" }, 1),
            new Question("Ile nóg ma kot?", new[] { "2", "3", "4", "5" }, 2)
        };
    }

    private void LoadCurrentQuestion()
    {
        var currentQuestion = _questions[_currentQuestionIndex];
        QuestionText = currentQuestion.Text;
        AnswerOptions = new ObservableCollection<AnswerOption>(
            currentQuestion.Answers.Select((a, index) => new AnswerOption(a, index == currentQuestion.CorrectIndex))
        );
        ResultMessage = string.Empty;
    }

    private void PreviousQuestion()
    {
        if (_currentQuestionIndex > 0)
        {
            _currentQuestionIndex--;
            LoadCurrentQuestion();
            ((Command)NextCommand).ChangeCanExecute();
            ((Command)PreviousCommand).ChangeCanExecute();
        }
    }

    private void NextQuestion()
    {
        if (_currentQuestionIndex < _questions.Count - 1)
        {
            _currentQuestionIndex++;
            LoadCurrentQuestion();
            ((Command)NextCommand).ChangeCanExecute();
            ((Command)PreviousCommand).ChangeCanExecute();
        }
    }

    private void CheckAnswer()
    {
        var selectedAnswers = AnswerOptions.Where(a => a.IsSelected).ToList();
        if (selectedAnswers.Count == 0)
        {
            ResultMessage = "Wybierz odpowiedź!";
            return;
        }

        bool isCorrect = selectedAnswers.All(a => a.IsCorrect) && selectedAnswers.Count == 1;
        ResultMessage = isCorrect ? "Poprawna odpowiedź!" : "Błędna odpowiedź!";
    }

    private void RestartQuiz()
    {
        _currentQuestionIndex = 0;
        LoadCurrentQuestion();
    }

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class Question
{
    public string Text { get; }
    public string[] Answers { get; }
    public int CorrectIndex { get; }

    public Question(string text, string[] answers, int correctIndex)
    {
        Text = text;
        Answers = answers;
        CorrectIndex = correctIndex;
    }
}

public class AnswerOption : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private bool _isSelected;
    public string Text { get; }
    public bool IsCorrect { get; }

    public bool IsSelected
    {
        get => _isSelected;
        set { _isSelected = value; OnPropertyChanged(nameof(IsSelected)); }
    }

    public AnswerOption(string text, bool isCorrect)
    {
        Text = text;
        IsCorrect = isCorrect;
    }

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}