using MauiControls.Pages;

namespace MauiControls
{
    public partial class App: Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MauiPresentationControls());
            MainPage = new NavigationPage(new MauiCommandsControls());

            MainPage = new NavigationPage(new MauiSetValueControls());

            MainPage = new NavigationPage(new MauiEditControls());

            MainPage = new NavigationPage(new MauiEditorControls());
        }
    }
}