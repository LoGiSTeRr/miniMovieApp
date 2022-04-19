using WpfApp1.Models;

namespace WpfApp1.Services;

public interface IService
{
    public SearchResult Search(string str);
}