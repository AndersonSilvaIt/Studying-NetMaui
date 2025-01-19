using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MeusLivros.MVVM.Models;
using MeusLivros.Services;

namespace MeusLivros.MVVM.ViewModels
{
    [QueryProperty(nameof(Livro), "LivroObject")]
    public partial class UpdateLivroViewModel : ObservableObject
    {
        private readonly ILivroService _livroService;

        [ObservableProperty]
        public Livro _livro;
        public UpdateLivroViewModel(ILivroService service)
        {
            _livroService = service;
        }

        [RelayCommand]
        private async Task UpdateLivro()
        {
            if (!string.IsNullOrWhiteSpace(Livro.Titulo))
            {
                await _livroService.InitializeAsync();
                await _livroService.AtualizaLivroAsync(Livro);

                await Shell.Current.GoToAsync("..");
            }
            else
            {
                AppShell.Current.DisplayAlert("Error", "Livro sem título", "Ok");
            }
        }

    }
}