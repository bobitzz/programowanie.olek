using System.Collections.ObjectModel;

namespace UnitCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> UnitsCollection { get; set; }
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
            UnitsCollection = new ObservableCollection<string>();
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

        }
    }

}
