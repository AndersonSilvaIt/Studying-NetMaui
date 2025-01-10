using ListaCarro.Models;
using MvvmHelpers;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ListaCarro.ViewModels
{
    public class CarrosListViewModel: BaseViewModel
    {
        public ObservableCollection<Carro> Carros { get; set; } = new ObservableCollection<Carro>();

        public Command GetCarrosCommand { get; set; }

        public CarrosListViewModel()
        {
            Title = "Carros";

            GetCarrosCommand = new Command(async () => await GetCarrosAsync());
        }

        async Task GetCarrosAsync()
        {
            if(IsBusy) return;

            try
            {
                IsBusy = true;

                var client = new HttpClient();
                var json = await client.GetStringAsync("https://macoratti.net/json/carros.json");
                var carros = JsonConvert.DeserializeObject<List<Carro>>(json);

                Carros.Clear();
                foreach(var carro in carros)
                {
                    Carros.Add(carro);
                }
            } catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
            } finally
            {
                IsBusy = false;
            }
        }
    }
}