using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherService
    {
        private const string ApiBaseUrl = "https://api.openweathermap.org/data/2.5/weather";
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public WeatherService(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<double?> GetTemperatureAsync(string city)
        {
            var requestUrl = $"{ApiBaseUrl}?q={city}&appid={_apiKey}&units=metric";

            try
            {
                var response = await _httpClient.GetAsync(requestUrl);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Błąd: Nie udało się pobrać danych dla miasta {city}.");
                    return null;
                }

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var weatherData = JsonSerializer.Deserialize<WeatherResponse>(jsonResponse);

                return weatherData?.Main?.Temp;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
                return null;
            }
        }
    }

    public class WeatherResponse
    {
        public MainData Main { get; set; }
    }

    public class MainData
    {
        public double Temp { get; set; }
    }

    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Podaj klucz API OpenWeatherMap:");
            var apiKey = Console.ReadLine();

            var weatherService = new WeatherService(apiKey);

            while (true)
            {
                Console.WriteLine("\nPodaj nazwę miasta (lub wpisz 'exit', aby zakończyć):");
                var city = Console.ReadLine();

                if (string.Equals(city, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                var temperature = await weatherService.GetTemperatureAsync(city);

                if (temperature.HasValue)
                {
                    Console.WriteLine($"Aktualna temperatura w {city} to {temperature.Value}°C.");
                }
            }

            Console.WriteLine("Dziękujemy za skorzystanie z aplikacji pogodowej!");
        }
    }
}
