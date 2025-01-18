namespace JogosInfantis.Views;

public partial class JogosInfantisView : ContentPage
{
    public JogosInfantisView()
    {
        InitializeComponent();
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        ImageButton button = (ImageButton)sender;
        Navigation.PushAsync(new JogosInfantisDetailsView(button.CommandParameter.ToString()));
    }
}