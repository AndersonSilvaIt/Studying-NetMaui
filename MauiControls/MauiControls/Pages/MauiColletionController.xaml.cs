using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiColletionController: ContentPage
{
    public MauiColletionController()
    {
        InitializeComponent();
        BindingContext = new FotoViewModel();
    }

    private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        if(e.CurrentItem != null && e.PreviousItem != null)
        {
            Foto anterior = e.PreviousItem as Foto;
            Foto proximo = e.CurrentItem as Foto;
            await DisplayAlert("CarouselView", $"anterior={anterior.Nome} \n\npróximo={proximo.Nome}", "OK");
        }
    }
}