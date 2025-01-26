﻿using AppLanches.Pages;
using AppLanches.Services;
using AppLanches.Validations;

namespace AppLanches
{
    public partial class AppShell: Shell
    {
        private readonly ApiService _apiService;
        private readonly IValidator _validator;

        public AppShell(ApiService apiService, IValidator validator)
        {
            InitializeComponent();
            _apiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
            _validator = validator;
            ConfigureShell();
        }

        private void ConfigureShell()
        {
            var homePage = new HomePage(_apiService, _validator);
            var carrinhoPage = new CarrinhoPage();
            var favoritosPage = new FavoritosPage();
            var perfilPage = new PerfilPage();

            Items.Add(new TabBar
            {
                Items =
                {
                    new ShellContent{ Title = "Home", Icon = "home", Content=homePage},
                    new ShellContent{ Title = "Carrinho", Icon = "cart", Content=carrinhoPage},
                    new ShellContent{ Title = "Favoritos", Icon = "heart", Content=favoritosPage},
                    new ShellContent{ Title = "Parfil", Icon = "profile", Content=perfilPage}
                }
            });
        }
    }
}