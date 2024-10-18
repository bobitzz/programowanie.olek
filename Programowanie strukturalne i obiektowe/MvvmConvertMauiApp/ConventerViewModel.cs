using System.Text;
using System.Threading.Tasks;

namespace MvvmConvertMauiApp
{
    public class ConventerViewModel : BindableObject
    {
        public List<string> Units {  get; set; }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; OnPropertyChanged(); }
        }
        public string SelectedUnit { get; set; }
        public string UnitToChange { get; set; }
        private Command convertCommand{ get; set; }
        public Command ConvertCommand
        {
            get { return convertCommand; }
            set { convertCommand = value; }
        }

        public ConventerViewModel()
        {
            Units = new List<string>();
            ConvertCommand = new Command(Converter);

            Units.Add("celcjusz");
            Units.Add("farenheit");

            SelectedUnit = Units.First();
        }

        private void Converter()
        {
            double.TryParse(UnitToChange, out double unitToChange);
            double result;

            switch(SelectedUnit)
            {
                case "celcjusz":
                    result = 2 * (unitToChange - 0.1 * unitToChange) + 32;
                    ShowMessage(result, "celcjusza");
                    break;
                case "farenheit":
                    result = ((unitToChange - 32) / 2) * 1.1;
                    ShowMessage(result, "fatenheita");
                    break;
                default:
                    break;
            }
        }

        private void ShowMessage(double value, string unit)
        {
            Message = $"Przeliczenie na {value} {unit}";
        }
    }
}
