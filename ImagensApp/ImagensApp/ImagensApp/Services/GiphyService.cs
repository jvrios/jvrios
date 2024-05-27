using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

public class GiphyService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public GiphyService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["Giphy:ApiKey"];
    }

    public async Task<JObject> SearchGifsAsync(string query, int limit = 20)
    {
        var response = await _httpClient.GetStringAsync($"https://api.giphy.com/v1/gifs/search?api_key={_apiKey}&q={query}&limit={limit}");
        return JObject.Parse(response);
    }
}
