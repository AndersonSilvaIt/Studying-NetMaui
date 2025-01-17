using MauiCalculadora.MVVM.ViewModels;

namespace MauiCalculadora.MVVM.Views;

public partial class CalculadoraView : ContentPage
{
    public CalculadoraView()
    {
        InitializeComponent();
        BindingContext = new CalculadoraViewModel();
    }
}