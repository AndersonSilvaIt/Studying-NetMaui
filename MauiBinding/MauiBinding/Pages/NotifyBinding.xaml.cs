using MauiBinding.Models;

namespace MauiBinding.Pages;

public partial class NotifyBinding: ContentPage
{
    Produto produto = new Produto();
    public NotifyBinding()
    {
        InitializeComponent();
        produto = new Produto
        {
            Nome = "IPhone 5",
            Preco = 5000.00m,
            Estoque = 5
        };

        BindingContext = produto;
    }

    private async void btnAtualiza_Clicked(object sender, EventArgs e)
    {
        produto.Nome = "Galaxy SamSung 10";
        produto.Preco = 6000.00m;
        produto.Estoque = 3;

        await DisplayAlert("Produto Atualizado",
                    $"{produto.Nome} - {produto.Preco} - {produto.Equals}", 
                    "Ok");
    }
}