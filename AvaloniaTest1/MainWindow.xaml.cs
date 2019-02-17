using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaExample.Managers;
using AvaloniaExample.Models;

namespace AvaloniaExample
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            ContentControl contentControl = this.FindControl<ContentControl>("TestTest");
            Storage storage = new Storage();
            NavigationModel navigationModel = new NavigationModel(contentControl, storage);
            NavigationManager.Instance.Initialize(navigationModel);
            navigationModel.Navigate(ModesEnum.Login);
            
        }
    }
}
