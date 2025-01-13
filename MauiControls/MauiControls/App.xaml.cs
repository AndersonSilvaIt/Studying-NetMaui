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

            MainPage = new NavigationPage(new MauiColletionController());

            MainPage = new NavigationPage(new ListViewDemo());

            MainPage = new NavigationPage(new CollectionViewDemo());

            MainPage = new NavigationPage(new PickerViewDemo());

            MainPage = new NavigationPage(new TableViewDemo());
        }
    }
}