using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmSimpleBindingCalculatorMauiApp
{
    public class calculatorViewModel : BindableObject
    {
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public bool IsOperationAdd { get; set; }
        public bool IsOperationSub { get; set; }
        public bool IsOperationMul { get; set; }
        public bool IsOperationDiv { get; set; }

        private string resultMessage;

        public string ResultMessage
        {
            get
            {
                return resultMessage;
            }
            set
            {
                resultMessage = value;
                OnPropertyChanged();
            }
        }

        private Color colorMessage;
        public Color ColorMessage
        {
            get
            {
                return colorMessage;
            }
            set 
            { 
                colorMessage = value; 
                OnPropertyChanged(); 
            }
        }

        private Command calculatorComand;
        public Command CalculatorComand
        {
            get { return calculatorComand; }
            set { calculatorComand = value; }
        }

        public calculatorViewModel()
        {
            CalculatorComand = new Command(Calculate);
        }

        private void Calculate()
        {
            int firstNumber;
            if (!int.TryParse(FirstNumber, out firstNumber))
            {
                //komunikat o błędzie
                ResultMessage = "Niepoprawna pierwsza liczba";
                ColorMessage = Colors.Red;
                return;
            }

            if (!int.TryParse(SecondNumber, out int secondNumber))
            {
                //komunikat o błędzie
                ResultMessage = "Niepoprawna druga liczba";
                ColorMessage = Colors.Red;
                return;
            }

            int result = 0;
            if (IsOperationAdd)
            {
                result = firstNumber + secondNumber;
            }
            else if (IsOperationSub)
            {
                result = firstNumber - secondNumber;
            }
            else if (IsOperationMul)
            {
                result = firstNumber * secondNumber;
            }
            else if (IsOperationDiv)
            {
                result = firstNumber / secondNumber;
            }
            ResultMessage = $"Wynik operacji {result}";
            ColorMessage = Colors.Pink;
        }
    }
}
