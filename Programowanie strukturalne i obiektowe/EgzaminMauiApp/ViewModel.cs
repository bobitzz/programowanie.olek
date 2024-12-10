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
            Die1 = dieceImages[random.Next(0, 5)];
            Die2 = dieceImages[random.Next(0, 5)];
            Die3 = dieceImages[random.Next(0, 5)];
            Die4 = dieceImages[random.Next(0, 5)];
            Die5 = dieceImages[random.Next(0, 5)];

            int rollResult = 5;
            rollResult += Array.IndexOf(dieceImages, Die1);
            rollResult += Array.IndexOf(dieceImages, Die2);
            rollResult += Array.IndexOf(dieceImages, Die3);
            rollResult += Array.IndexOf(dieceImages, Die4);
            rollResult += Array.IndexOf(dieceImages, Die5);

            totalScore += rollResult;

            CurrentRollResult = $"Wynik tego losowania: {rollResult}";
            TotalGameResult = $"Wynik gry: {totalScore}";
        }

        public void ResetGame()
        {
            Die1 = "question.jpg";
            Die2 = "question.jpg";
            Die3 = "question.jpg";
            Die4 = "question.jpg";
            Die5 = "question.jpg";
            CurrentRollResult = "Wynik tego losowania: 0";
            totalScore = 0;
            TotalGameResult = "Wynik gry: 0";
        }
    }
}
