using MvvmDemo.Mvvm.ViewModels;

namespace MvvmDemo.Mvvm.Views;

public partial class EnderecoView : ContentPage
{
	public EnderecoView()
	{
		InitializeComponent();
        BindingContext = new EnderecoViewModel();
    }
}