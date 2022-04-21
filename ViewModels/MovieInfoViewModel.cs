using CommunityToolkit.Mvvm.ComponentModel;
using WpfApp1.Models;

namespace WpfApp1.ViewModels;

public partial class MovieInfoViewModel : BaseViewModel
{
    [ObservableProperty]
    private Movie _movie;
}