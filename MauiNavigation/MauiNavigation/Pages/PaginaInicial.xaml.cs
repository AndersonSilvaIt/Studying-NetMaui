namespace MauiNavigation.Pages;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
	}

    private async void btnPaginaInicial_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Pagina2());
    }

    private async void btnPaginaModal_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new PaginaModal());
    }
}