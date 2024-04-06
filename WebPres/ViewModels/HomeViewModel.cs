
using System.Threading.Tasks;
using AvaloniaHelpers.Navigation.MVVM;
using CommunityToolkit.Mvvm.Input;

namespace WebPres.ViewModels;
internal partial class HomeViewModel : BaseViewModel
{
    public string Title { get; } = "Your Flow(s)";
    [RelayCommand]
    public async Task CreateNewFlow()
    {
        
    }

}
