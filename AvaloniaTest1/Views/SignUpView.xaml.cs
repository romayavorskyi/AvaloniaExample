using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaExample.Models;
using AvaloniaExample.ViewModels;

namespace AvaloniaExample.Views
{
    public class SignUpView : UserControl
    {
        public SignUpView(Storage storage)
        {
            this.InitializeComponent();
            DataContext = new SignUpViewModel(storage);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
