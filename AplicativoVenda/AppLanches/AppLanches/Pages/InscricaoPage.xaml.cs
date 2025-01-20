using AppLanches.Services;
using AppLanches.Validations;
using System.Text;

namespace AppLanches.Pages;

public partial class InscricaoPage : ContentPage
{
    private readonly ApiService _apiService;
    private readonly IValidator _validator;

    public InscricaoPage(ApiService apiService, IValidator validator)
    {
        InitializeComponent();
        _apiService = apiService;
        _validator = validator;
    }

    private async void BtnSignup_Clicked_2(object sender, EventArgs e)
    {
        if (await _validator.Validar(EntNome.Text, EntEmail.Text, EntPhone.Text, EntPassword.Text))
        {
            var response = await _apiService.RegistrarUsuario(EntNome.Text, EntEmail.Text, EntPhone.Text, EntPassword.Text);

            if (!response.HasError)
            {
                await DisplayAlert("Aviso", "Sua Conta foi criada com sucesso!!", "Ok");
                await Navigation.PushAsync(new LoginPage(_apiService, _validator));
            }
            else
            {
                await DisplayAlert("Erro", "Algo deu errado!!!", "Cancelar");
            }
        }
        else
        {
            StringBuilder mensagemErro = new StringBuilder();
            mensagemErro.AppendLine(_validator.NomeErro != null ? _validator.NomeErro : "");
            mensagemErro.AppendLine(_validator.EmailErro != null ? _validator.EmailErro : "");
            mensagemErro.AppendLine(_validator.TelefoneErro != null ? _validator.TelefoneErro : "");
            mensagemErro.AppendLine(_validator.SenhaErro != null ? _validator.SenhaErro : "");

            await DisplayAlert("Erro", mensagemErro.ToString(), "Ok");
        }
    }

    private async void TapLogin_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new LoginPage(_apiService, _validator));
    }
}