using WpfApp1.Enums;
using WpfApp1.ViewModels;

namespace WpfApp1.Fabrics;

public class ViewModelsFabric
{
    public BaseViewModel Create(ViewModelEnum viewModelType)
    {
        return viewModelType switch
        {
            ViewModelEnum.SearchViewModel => new SearchViewModel(),
            ViewModelEnum.MovieInfoViewModel => new MovieInfoViewModel(),
        };
    }
}