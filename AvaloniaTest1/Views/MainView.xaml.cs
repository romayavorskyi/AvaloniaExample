using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaExample.Models;
using AvaloniaExample.ViewModels;

namespace AvaloniaExample.Views
{
    public class MainView : UserControl
    {
        public MainView(Storage storage)
        {
            this.InitializeComponent();
            DataContext = new MainViewModel(storage);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
