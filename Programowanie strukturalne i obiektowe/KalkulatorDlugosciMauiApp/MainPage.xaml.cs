using System.Collections.ObjectModel;

namespace KalkulatorDlugosciMauiApp
{
    public partial class MainPage : ContentPage
    {
        public Collection<string> UnitsCollection { get; set; }
        public string SelectedUnit { get; set; }
        public string SelectedUnitToChange { get; set; }
        public string UnitToChange { get; set; }
        private string unitCalculatorResult;

        public string UnitCalculatorResult
        {
            get { return unitCalculatorResult; }
            set
            {
                unitCalculatorResult = value;
                OnPropertyChanged();
            }
        }


        public MainPage()
        {
            UnitsCollection = new Collection<string>();
            UnitsCollection.Add("mm");
            UnitsCollection.Add("cm");
            UnitsCollection.Add("dm");
            UnitsCollection.Add("m");
            UnitsCollection.Add("km");

            SelectedUnit = UnitsCollection.First();
            SelectedUnitToChange = UnitsCollection.First();

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double.TryParse(UnitToChange, out double unitToChange);

            switch (SelectedUnitToChange)
            {
                case "mm":
                    showResult(MilimettersToCentimeter(unitToChange, SelectedUnit));
                    break;
                case "cm":
                    showResult(MilimettersToCentimeter(unitToChange, SelectedUnit) / 10);
                    break;
                case "dm":
                    showResult(MilimettersToCentimeter(unitToChange, SelectedUnit) / 100);
                    break;
                case "m":
                    showResult(MilimettersToCentimeter(unitToChange, SelectedUnit) / 1000);
                    break;
                case "km":
                    showResult(MilimettersToCentimeter(unitToChange, SelectedUnit) / 1000000);
                    break;
                default:
                    break;
            }
        }

        private double MilimettersToCentimeter(double value, string unit)
        {
            switch (unit)
            {
                case "mm":
                    return value;
                    break;
                case "cm":
                    value = value * 10;
                    break;
                case "dm":
                    value = value * 100;
                    break;
                case "m":
                    value = value * 1000;
                    break;
                case "km":
                    value = value * 1000000;
                    break;
                default:
                    break;
            }

            return value;
        }
        private void showResult(double value)
        {
            UnitCalculatorResult = "Konwersja jest rowna: " + value;
        }
    }

}
