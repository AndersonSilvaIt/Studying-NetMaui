namespace MauiControls.Pages;

public partial class TableViewDemo: ContentPage
{
    public TableViewDemo()
    {
        InitializeComponent();
    }

    private void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Alerta Cinto Seguran�a",
            "Voc� selecionou/deeselecionou este acess�rio", "OK");
    }
}