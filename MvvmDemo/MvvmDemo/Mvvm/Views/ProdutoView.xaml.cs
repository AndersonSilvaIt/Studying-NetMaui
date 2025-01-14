using MvvmDemo.Mvvm.ViewModels;

namespace MvvmDemo.Mvvm.Views;

public partial class ProdutoView : ContentPage
{
	public ProdutoView()
	{
		InitializeComponent();

		BindingContext = new ProdutoViewModel();
	}
}