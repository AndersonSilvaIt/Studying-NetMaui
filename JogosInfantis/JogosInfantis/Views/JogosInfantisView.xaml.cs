namespace JogosInfantis.Views;

public partial class JogosInfantisView : ContentPage
{
    public JogosInfantisView()
    {
        InitializeComponent();
    }

    private async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
    {
        ImageButton button = (ImageButton)sender;
        await Navigation.PushAsync(new JogosInfantisDetailsView(button.CommandParameter.ToString()));
    }
}