using MvvmDemo.Mvvm.Views;

namespace MvvmDemo
{
    public partial class App: Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EnderecoView());
        }
    }
}
