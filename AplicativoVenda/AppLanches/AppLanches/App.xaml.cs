using AppLanches.Pages;
using AppLanches.Services;

namespace AppLanches
{
    public partial class App : Application
    {
        private readonly ApiService _apiService;

        public App(ApiService apiService)
        {
            _apiService = apiService;
            InitializeComponent();

            MainPage = new NavigationPage(new InscricaoPage(_apiService));
        }

    }
}
