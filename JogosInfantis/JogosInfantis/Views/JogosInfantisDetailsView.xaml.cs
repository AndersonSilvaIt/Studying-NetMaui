using JogosInfantis.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogosInfantis.Views;

public partial class JogosInfantisDetailsView : ContentPage
{
    public JogosInfantisDetailsView(string category)
    {
        InitializeComponent();
        ExibirJogo(category);
        Title = category;
    }

    private void CvJogos_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as JogoItem;
        TextToSpeech.SpeakAsync(selectedItem.Name);
    }

    private void ExibirJogo(string categoryName)
    {
        JogoData jogo = new JogoData();
        switch (categoryName)
        {
            case "Numbers":
                CvJogos.ItemsSource = jogo.Numbers; break;
            case "Letters":
                CvJogos.ItemsSource = jogo.Letters; break;
            case "Shapes":
                CvJogos.ItemsSource = jogo.Shapes; break;
            case "Colors":
                CvJogos.ItemsSource = jogo.Colors; break;
            case "Fruits":
                CvJogos.ItemsSource = jogo.Fruits; break;
            case "Animals":
                CvJogos.ItemsSource = jogo.Animals; break;
            default:
                break;
        }
    }
}