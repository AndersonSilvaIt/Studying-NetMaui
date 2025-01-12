namespace ListaCarro
{
    public partial class App: Application
    {
        public App()
        {
            InitializeComponent();

            //var navPage = new NavigationPage(new MinhaPagina());
            //
            //navPage.BarBackground = Colors.Yellow;
            //navPage.BarTextColor = Colors.Blue;
            //
            //MainPage = navPage;

            // Para criar o elemento Root de uma navegação
            //MainPage = new NavigationPage(new MinhaPagina());

            //MainPage = new FlyoutPageDemo();

            //MainPage = new TabbedPageDemo();
            //MainPage = new StackLayoutDemo();

            //MainPage = new StackLayoutLogin();
            //MainPage = new GridLayoutDemo();
            MainPage = new GridLogin();
        }
    }
}
