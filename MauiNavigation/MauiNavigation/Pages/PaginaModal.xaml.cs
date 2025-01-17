namespace MauiNavigation.Pages;

public partial class PaginaModal : ContentPage
{
	public PaginaModal()
	{
		InitializeComponent();
	}

    private void button1_Clicked(object sender, EventArgs e)
    {

    }

    private async void button1_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }


    protected override bool OnBackButtonPressed()
    {
        // Desabilita o botão de retornar que aparece no Android
        return true;
    }
}