using AppLanches.Pages;
using AppLanches.Services;
using AppLanches.Validations;

namespace AppLanches
{
    public partial class App : Application
    {
        private readonly ApiService _apiService;
        private readonly IValidator _validator;
        public App(ApiService apiService, IValidator validator)
        {
            _apiService = apiService;
            InitializeComponent();
            _validator = validator;

            MainPage = new NavigationPage(new InscricaoPage(_apiService, _validator));
        }

    }
}
