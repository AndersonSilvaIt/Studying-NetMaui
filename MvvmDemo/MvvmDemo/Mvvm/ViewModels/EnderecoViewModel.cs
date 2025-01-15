using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text;

namespace MvvmDemo.Mvvm.ViewModels
{

    //[INotifyPropertyChanged], se eu precisar que minha viewmodel herde de outra classe, eu posso decorar essa com o INotifyPropertyChanged que também usará a lib CommunityToolkit.
    public partial class EnderecoViewModel: ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Endereco))]
        private string _nome;

        [NotifyPropertyChangedFor(nameof(Endereco))]
        [ObservableProperty]
        private string _sobrenome;

        [NotifyPropertyChangedFor(nameof(Endereco))]
        [ObservableProperty]
        private string _rua;

        [NotifyPropertyChangedFor(nameof(Endereco))]
        [ObservableProperty]
        private string _cep;

        [NotifyPropertyChangedFor(nameof(Endereco))]
        [ObservableProperty]
        private string _cidade;

        public string Endereco
        {
            get
            {
                var stringBuilder = new StringBuilder();
                stringBuilder
                    .AppendLine($"{Nome} {Sobrenome}")
                    .AppendLine(Rua)
                    .AppendLine($"{Cep} - {Cidade}");
                return stringBuilder.ToString();
            }
        }

        [RelayCommand]
        private void ImprimirEndereco(string endereco)
        {
            App.Current.MainPage.DisplayAlert("Endereco", endereco, "OK");
        }
    }
}
