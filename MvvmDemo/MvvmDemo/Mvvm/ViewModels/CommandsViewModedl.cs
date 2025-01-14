using System.Windows.Input;

namespace MvvmDemo.Mvvm.ViewModels
{
    public class CommandsViewModedl
    {
        public ICommand ButtonClickCommand => new Command(() => App.Current.MainPage.DisplayAlert("Alerta", "Mensagem", "Ok"));
        public ICommand SearchCommand { get; }
        public string SearchTerm { get; set; }

        public CommandsViewModedl()
        {
            SearchCommand = new Command((searchText) => {
                var texto = searchText;
                //Alerta(texto);
            });
        }

        private void Alerta(string mensagem)
        {
            App.Current.MainPage.DisplayAlert("Alerta", mensagem, "Ok");
        }
    }
}
