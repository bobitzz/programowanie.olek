using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminMauiApp
{
    internal class GameViewModel : BindableObject
    {
        private string currentRollResult;
        public string CurrentRollResult
        {
            get { return currentRollResult; }
            set { currentRollResult = value; OnPropertyChanged(); }
        }

        private string totalGameResult;
        public string TotalGameResult
        {
            get { return totalGameResult; }
            set { totalGameResult = value; OnPropertyChanged(); }
        }

        private string die1;

        public string Die1
        {
            get { return die1; }
            set { die1 = value; OnPropertyChanged(); }
        }

        private string die2;

        public string Die2
        {
            get { return die2; }
            set { die2 = value; OnPropertyChanged(); }
        }

        private string die3;

        public string Die3
        {
            get { return die3; }
            set { die3 = value; OnPropertyChanged(); }
        }

        private string die4;

        public string Die4
        {
            get { return die4; }
            set { die4 = value; OnPropertyChanged(); }
        }

        private string die5;

        public string Die5
        {
            get { return die5; }
            set { die5 = value; OnPropertyChanged(); }
        }

        private Command rollCommand;

        public Command RollCommand
        {
            get { return rollCommand; }
            set { rollCommand = value; }
        }

        private Command resetGameCommand;

        public Command ResetGameCommand
        {
            get { return resetGameCommand; }
            set { resetGameCommand = value; }
        }

        private string[] diceImages =
        {
        "k1.jpg",
        "k2.jpg",
        "k3.jpg",
        "k4.jpg",
        "k5.jpg",
        "k6.jpg",
    };

        public GameViewModel()
        {
            RollCommand = new Command(RollDice);
            ResetGameCommand = new Command(ResetGame);
            Die1 = "question.jpg";
            Die2 = "question.jpg";
            Die3 = "question.jpg";
            Die4 = "question.jpg";
            Die5 = "question.jpg";
        }

        int totalScore = 0;

        public void RollDice()
        {
            Random random = new Random();
            Die1 = diceImages[random.Next(0, 6)];
            Die2 = diceImages[random.Next(0, 6)];
            Die3 = diceImages[random.Next(0, 6)];
            Die4 = diceImages[random.Next(0, 6)];
            Die5 = diceImages[random.Next(0, 6)];

            int rollResult = 5;
            rollResult += Array.IndexOf(diceImages, Die1);
            rollResult += Array.IndexOf(diceImages, Die2);
            rollResult += Array.IndexOf(diceImages, Die3);
            rollResult += Array.IndexOf(diceImages, Die4);
            rollResult += Array.IndexOf(diceImages, Die5);

            totalScore += rollResult;

            CurrentRollResult = $"Current roll result: {rollResult}";
            TotalGameResult = $"Total game score: {totalScore}";
        }

        public void ResetGame()
        {
            Die1 = "question.jpg";
            Die2 = "question.jpg";
            Die3 = "question.jpg";
            Die4 = "question.jpg";
            Die5 = "question.jpg";
            CurrentRollResult = "Current roll result: 0";
            totalScore = 0;
            TotalGameResult = "Total game score: 0";
        }
    }
}
