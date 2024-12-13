using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminMauiApp
{
    public class ViewModel : BindableObject
    {
        #region propfull
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

        private Command resetGameCommand;
        public Command ResetGameCommand
        {
            get { return resetGameCommand; }
            set { resetGameCommand = value; }
        }

        private Command rollDiceCommand;
        public Command RollDiceCommand
        {
            get { return rollDiceCommand; }
            set { rollDiceCommand = value; }
        }
        #endregion

        private string[] dieceImages =
        {
            "k1.jpg",
            "k2.jpg",
            "k3.jpg",
            "k4.jpg",
            "k5.jpg",
            "k6.jpg",
        };

        public ViewModel()
        {
            RollDiceCommand = new Command(RollDice);
            ResetGameCommand = new Command(ResetGame);
            ResetGameCommand.Execute(this);
        }

        private int totalGameScore = 0;
        
        public void RollDice()
        {
            Random random = new Random();

            int[] dieceValues = new int[5]
            {
                random.Next(1, 7),
                random.Next(1, 7),
                random.Next(1, 7),
                random.Next(1, 7),
                random.Next(1, 7)
            };

            Die1 = dieceImages[dieceValues[0] - 1];
            Die2 = dieceImages[dieceValues[1] - 1];
            Die3 = dieceImages[dieceValues[2] - 1];
            Die4 = dieceImages[dieceValues[3] - 1];
            Die5 = dieceImages[dieceValues[4] - 1];

            var duplicateValues = dieceValues.GroupBy(x => x).Where(g => g.Count() > 1).SelectMany(g => g);
            int currentRollTotal = duplicateValues.Sum();

            totalGameScore += currentRollTotal;
            CurrentRollResult = $"Wynik tego losowania {currentRollTotal}";
            TotalGameResult = $"Wynik całej gry {totalGameScore}";
        }

        public void ResetGame()
        {
            Die1 = "question.jpg";
            Die2 = "question.jpg";
            Die3 = "question.jpg";
            Die4 = "question.jpg";
            Die5 = "question.jpg";
            CurrentRollResult = $"Wynik tego losowania 0";
            totalGameScore = 0;
            TotalGameResult = $"Wynik całej gry 0";
        }
    }
}