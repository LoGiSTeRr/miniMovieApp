using System.Net;
using System.Windows;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels;



// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

public partial class SearchViewModel : BaseViewModel
{
    private MoviesProxy _moviesProxy;

    [ObservableProperty] private string _textBoxText;
    [ObservableProperty] private SearchResult _searchResult;
    
    public SearchViewModel()
    {
        _moviesProxy = new MoviesProxy(new MovieTmdbService());
    }

    [ICommand] private void Search()
    {
        SearchResult = _moviesProxy.Search(TextBoxText);
        MessageBox.Show("1");

    }

    [ICommand]
    private void OpenMovie(Movie movie)
    {
        MessageBox.Show("2");
    }
}