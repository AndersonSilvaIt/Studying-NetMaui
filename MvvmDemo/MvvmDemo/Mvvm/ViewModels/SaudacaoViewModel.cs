using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MvvmDemo.Mvvm.ViewModels
{
    public class SaudacaoViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void Notificar([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public string Nome { get; set; }

        private string _mensagem;
        public string Mensagem
        {
            get
            {
                return _mensagem;
            }
            set
            {
                _mensagem = value;
                Notificar();
            }
        }

        public ICommand SaudacaoCommand { get; private set; }

        public SaudacaoViewModel()
        {
            SaudacaoCommand = new Command(SaudacaoCmd);
        }

        void SaudacaoCmd()
        {
            Mensagem = $"Bem-Vindo {Nome}";
        }
    }
}