using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMauiApp
{
    public class CalculatorViewModel : BindableObject
    {
        private string calculatingResult;

        public string CalculatingResult
        {
            get { return calculatingResult; }
            set { calculatingResult = value; OnPropertyChanged(); }
        }

        private Command numberCommand;
        public Command NumberCommand
        {
            get
            {
                if (numberCommand == null)
                    numberCommand = new Command<string>((string number) =>
                    {
                        if (ifOperationExecute == false)
                            CalculatingResult += number;
                        else
                        {
                            CalculatingResult = number;
                            ifOperationExecute = false;
                        }
                    });
                return numberCommand;
            }
            set { numberCommand = value; }
        }

        private Command operationCommand;
        public Command OperationCommand
        {
            get
            {
                if (operationCommand == null)
                    operationCommand = new Command<string>((string operationSign) =>
                    {
                        int firstNumber = prevNumber;
                        int secondNumber = int.Parse(calculatingResult);
                        CalculatingResult = GetOperationResult(prevOperationSign, firstNumber, secondNumber).ToString();
                        prevOperationSign = operationSign;
                        prevNumber = int.Parse(calculatingResult);
                        ifOperationExecute = true;
                    });
                return operationCommand;
            }
            set { operationCommand = value; }
        }

        private string prevOperationSign;
        private int prevNumber;
        private bool ifOperationExecute = false;

        int GetOperationResult(string operationSign, int firstNumber, int secondNumber)
        {
            int result = 0;
            result = operationSign switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                _ => 0,
            };

            return result;
        }
    }
}