using Avalonia.Controls;


namespace WebPres;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        NavigationManager.OnViewChanging += x => this.ContentControl.Content = x.View;


    }
}