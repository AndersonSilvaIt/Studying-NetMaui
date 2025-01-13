namespace MauiControls.Pages;

public partial class TableViewDemo: ContentPage
{
    public TableViewDemo()
    {
        InitializeComponent();
    }

    private void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Alerta Cinto Segurança",
            "Você selecionou/deeselecionou este acessório", "OK");
    }
}