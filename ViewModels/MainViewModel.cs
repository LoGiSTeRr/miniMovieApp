using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfApp1.ViewModels;




public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    private BaseViewModel? currentViewModel;

    public MainViewModel()
    {
        CurrentViewModel = new SearchViewModel();
        
    }
}