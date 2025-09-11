namespace NavigationMauiApp
{
    public partial class MainPage : ContentPage
    {
        private Page _page;
        public MainPage()
        {
            InitializeComponent();
            _page = new NextPage();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //if (Navigation is not null)
            Navigation.PushAsync(new NextPage());
            //Navigation.PushAsync(_page);
        }
    }
}
