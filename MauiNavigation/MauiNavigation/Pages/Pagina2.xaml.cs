namespace MauiNavigation.Pages;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}

    private async void butto1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaFinal());
    }

    private async void butto2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}