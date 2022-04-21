using WpfApp1.Models;

namespace WpfApp1.Services;

public class MoviesProxy : IService
{
    private IService _service;
    public MoviesProxy(IService service)
    {
        _service = service;
    }
    public SearchResult Search(string str)
    {
        return _service.Search(str);
    }
}