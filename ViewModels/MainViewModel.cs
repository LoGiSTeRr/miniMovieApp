using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using WpfApp1.Fabrics;

namespace WpfApp1.ViewModels;




public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    private BaseViewModel? currentViewModel;

    private ViewModelsFabric _fabric;
    public MainViewModel()
    {
        CurrentViewModel = new SearchViewModel();
        //WeakReferenceMessenger.Default.Register();
    }
    
    
}