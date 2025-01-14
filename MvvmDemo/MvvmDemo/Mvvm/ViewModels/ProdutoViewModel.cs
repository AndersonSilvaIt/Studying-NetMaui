using MvvmDemo.Mvvm.Models;

namespace MvvmDemo.Mvvm.ViewModels
{
    public class ProdutoViewModel
    {
        public Produto Produto { get; set; }

        public ProdutoViewModel()
        {
            Produto = new Produto
            {
                Nome = "Caderno",
                Preco = 10.45m
            };
        }
    }
}