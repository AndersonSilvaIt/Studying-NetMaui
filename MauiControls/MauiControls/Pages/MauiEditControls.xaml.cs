namespace MauiControls.Pages;

public partial class MauiEditControls: ContentPage
{
    public MauiEditControls()
    {
        InitializeComponent();
    }

    private async void entry1_TextChanged(object sender, TextChangedEventArgs e)
    {
        string textoAntigo = e.OldTextValue;
        string novoTexto = e.NewTextValue;
        string meuTexto = entry1.Text;

        await DisplayAlert("Entry1 - TextChanged", $"{textoAntigo} + {novoTexto} + {meuTexto}", "OK");
    }

    private async void entry1_Completed(object sender, EventArgs e)
    {
        string texto = ((Entry)sender).Text;
        await DisplayAlert("Entry1 - Completed", texto, "OK");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await progressBar.ProgressTo(0.90, 1000, Easing.Linear);
    }
}