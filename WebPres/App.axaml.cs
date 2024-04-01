using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using WebPres.ViewModels;

namespace WebPres;
public partial class App : Application
{
    public static NavigationService NavigationManager { get; private set; } = new();
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);




    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();

        //Register Views and ViewModels here
        NavigationManager.RegisterView<HomeView, HomeViewModel>(nameof(HomeView));

        NavigationManager.NavigateToAsync(nameof(HomeView)).Wait();


    }
}