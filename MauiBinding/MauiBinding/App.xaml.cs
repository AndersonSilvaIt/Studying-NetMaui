using MauiBinding.Pages;

namespace MauiBinding
{
    public partial class App: Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            //MainPage = new NavigationPage(new SliderBinding());

            //MainPage = new NavigationPage(new BindingModes());

            MainPage = new NavigationPage(new NotifyBinding());
        }
    }
}