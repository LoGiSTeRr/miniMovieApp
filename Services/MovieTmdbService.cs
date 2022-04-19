using System.Net;
using Newtonsoft.Json;
using WpfApp1.Models;

namespace WpfApp1.Services;

public class MovieTmdbService : IService
{
    private string _apiKey;
    public MovieTmdbService()
    {
        _apiKey = "697ae244168bf931109d18ec944608b3";
    }
    private readonly WebClient webClient;
    public SearchResult Search(string str)
    {
        string jsonstring = webClient.DownloadString($"https://api.themoviedb.org/3/search/movie?api_key={_apiKey}&language=en-US&query={str}");
        return JsonConvert.DeserializeObject<SearchResult>(jsonstring);
    }
}