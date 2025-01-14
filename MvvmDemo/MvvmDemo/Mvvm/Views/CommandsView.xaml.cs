using MvvmDemo.Mvvm.ViewModels;

namespace MvvmDemo.Mvvm.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModedl();
	}
}