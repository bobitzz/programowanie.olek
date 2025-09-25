namespace Inf04._2025._06._01MauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SliderR.Value = 255;
            SliderG.Value = 255;
            SliderB.Value = 255;

            UpdateLargePreview();
        }

        void OnSliderChanged(object sender, ValueChangedEventArgs e)
        {
            UpdateLargePreview();
        }

        void UpdateLargePreview()
        {
            int r = (int)SliderR.Value;
            int g = (int)SliderG.Value;
            int b = (int)SliderB.Value;

            LargeRect.Color = Color.FromRgb(r / 255.0, g / 255.0, b / 255.0);
        }

        void OnPobierzClicked(object sender, EventArgs e)
        {
            int r = (int)SliderR.Value;
            int g = (int)SliderG.Value;
            int b = (int)SliderB.Value;

            LabelPobranyRGB.Text = $"Pobrany kolor: ({r},{g},{b})";
        }
    }
}
