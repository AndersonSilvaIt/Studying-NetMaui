using MauiControls.Models;

namespace MauiControls.Pages;

public partial class CollectionViewDemo : ContentPage
{
	public CollectionViewDemo()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}
}