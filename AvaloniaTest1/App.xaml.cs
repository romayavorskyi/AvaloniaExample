using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaExample
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
