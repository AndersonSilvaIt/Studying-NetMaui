using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiBinding.Models
{
    public class Produto: INotifyPropertyChanged
    {
        private string nome;
        private decimal preco;
        private int estoque;

        public string Nome
        {
            get => nome; set
            {
                nome = value;
                OnPropertyChanged();
            }
        }

        public decimal Preco
        {
            get => preco; set
            {
                preco = value;
                OnPropertyChanged();
            }
        }
        
        public int Estoque
        {
            get => estoque; set
            {
                estoque = value; OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string proName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proName));
        }
    }
}