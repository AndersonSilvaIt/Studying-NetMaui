namespace MauiNavigation.Pages;

public partial class DetalhesPage : ContentPage
{
    public DetalhesPage(string nome)
    {
        InitializeComponent();
        entryNome.Text = nome;
    }

    public DetalhesPage()
    {
        InitializeComponent();
    }
}