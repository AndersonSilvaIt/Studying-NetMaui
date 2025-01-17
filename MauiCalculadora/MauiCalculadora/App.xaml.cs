using MauiCalculadora.MVVM.Views;

namespace MauiCalculadora
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CalculadoraView());
        }
    }
}
