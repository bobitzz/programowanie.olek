namespace SimpleBindingCalculatorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public string firstNumber {  get; set; }
        public string SecondNumber {  get; set; }
        public string IsOperationAdd {  get; set; }
        public string IsOperationSub {  get; set; }
        public string IsOperationMul {  get; set; }
        public string IsOperationDiv {  get; set; }

        private string resultMessage;

        public string ResultMessage
        {
            get { return resultMessage; }
            set { resultMessage = value; OnPropertyChanged(); }
    }

}
