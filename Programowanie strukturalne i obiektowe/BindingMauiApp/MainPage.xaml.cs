namespace BindingMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string Message { get; set; }
        private string returnMessage {  get; set; }
        public string ReturnMessage {
            get { return returnMessage; }
            set { return returnMessage; }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            rotationLabel.Rotation = rotationSlider.Value;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ReturnMessage = "Wartość z entry " + Message;
            //OnPropertyChanged(ReturnMessage);
            //OnPropertyChanged(nameof(ReturnMessage));
        }
    }

}