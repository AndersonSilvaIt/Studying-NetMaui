using MvvmDemo.Mvvm.ViewModels;

namespace MvvmDemo.Mvvm.Views;

public partial class TimesView: ContentPage
{
    public TimesView()
    {
        InitializeComponent();

        BindingContext = new TimesViewModel();
    }
}