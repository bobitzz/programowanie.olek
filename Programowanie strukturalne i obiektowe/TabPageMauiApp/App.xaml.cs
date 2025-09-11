namespace TabPageMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            TabbedPage tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new MainPage() { Title = "Strona główma"});
            tabbedPage.Children.Add(new AboutPage());
            tabbedPage.Children.Add(new AnotherPage());

            tabbedPage.Children.Add(new NavigationPage(new AnotherPage()));

            return new Window(tabbedPage);
        }
    }
}