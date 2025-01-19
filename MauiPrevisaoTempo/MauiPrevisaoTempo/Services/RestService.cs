using MauiPrevisaoTempo.Models;
using System.Diagnostics;
using System.Text.Json;

namespace MauiPrevisaoTempo.Services
{
    public class RestService : IRestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        public RestService(HttpClient client)
        {
            _client = client;
            _serializerOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<WeatherData> GetWeatherData(string query)
        {
            WeatherData weatherData = null;
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        weatherData = await JsonSerializer.DeserializeAsync<WeatherData>(responseStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }

            return weatherData;
        }
    }
}
