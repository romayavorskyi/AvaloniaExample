using System;
using Avalonia.Controls;
using AvaloniaExample.Views;

namespace AvaloniaExample.Models
{

    public enum ModesEnum
    {
        Login,
        SingUp,
        Main
    }

    public class NavigationModel
    {
        private ContentControl _contentControl;
        private LoginView _loginView;
        private SignUpView _signUpView;
        private MainView _mainView;

        public NavigationModel(ContentControl contentControl, Storage storage)
        {
            _contentControl = contentControl;
            _loginView = new LoginView(storage);
            _signUpView = new SignUpView(storage);
            _mainView = new MainView(storage);
        }

        public void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Login:
                    _contentControl.Content = _loginView;
                    break;
                case ModesEnum.SingUp:
                    _contentControl.Content = _signUpView;
                    break;
                case ModesEnum.Main:
                    _contentControl.Content = _mainView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
    }
}
