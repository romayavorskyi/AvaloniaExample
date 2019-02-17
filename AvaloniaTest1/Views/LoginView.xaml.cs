using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaExample.Models;
using AvaloniaExample.ViewModels;

namespace AvaloniaExample.Views
{
    public class LoginView : UserControl
    {
        public LoginView(Storage storage)
        {
            this.InitializeComponent();
            DataContext = new LoginViewModel(storage);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
