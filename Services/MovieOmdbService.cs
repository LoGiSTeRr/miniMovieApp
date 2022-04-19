using WpfApp1.Models;

namespace WpfApp1.Services;

public class MovieOmdbService : IService
{
    private string _apiKey;
    public MovieOmdbService()
    {
        _apiKey = "697ae244168bf931109d18ec944608b3";
    }
    public SearchResult Search(string str)
    {
        return new SearchResult();
    }
}