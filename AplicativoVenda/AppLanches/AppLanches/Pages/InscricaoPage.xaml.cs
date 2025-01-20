using AppLanches.Services;

namespace AppLanches.Pages;

public partial class InscricaoPage : ContentPage
{
    private readonly ApiService _apiService;

    public InscricaoPage(ApiService apiService)
    {
        InitializeComponent();
        _apiService = apiService;
    }

    private async void BtnSignup_Clicked_2(object sender, EventArgs e)
    {
        var response = await _apiService.RegistrarUsuario(EntNome.Text, EntEmail.Text, EntPhone.Text, EntPassword.Text);

        if(!response.HasError)
        {
            await DisplayAlert("Aviso", "Sua Conta foi criada com sucesso!!", "Ok");
            await Navigation.PushAsync(new LoginPage(_apiService));
        }
        else
        {
            await DisplayAlert("Erro", "Algo deu errado!!!", "Cancelar");
        }
    }

    private async void TapLogin_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new LoginPage(_apiService));
    }
}