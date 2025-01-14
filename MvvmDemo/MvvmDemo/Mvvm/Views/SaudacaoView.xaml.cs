using MvvmDemo.Mvvm.ViewModels;

namespace MvvmDemo.Mvvm.Views;

public partial class SaudacaoView: ContentPage
{
    public SaudacaoView()
    {
        InitializeComponent();
        BindingContext = new SaudacaoViewModel();
    }
}