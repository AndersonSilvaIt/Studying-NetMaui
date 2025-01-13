using MauiControls.Models;

namespace MauiControls.Pages;

public partial class ListViewDemo : ContentPage
{
	public ListViewDemo()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}
}