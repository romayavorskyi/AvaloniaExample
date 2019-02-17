using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AvaloniaExample.Models;
using ReactiveUI;

namespace AvaloniaExample.ViewModels
{
    public class LoginViewModel: INotifyPropertyChanged
    {
        private string _name;
        private string _password;

        private ICommand _loginCommand;
        private ICommand _signUpCommand;

        public LoginModel Model { get; private set; }

        public LoginViewModel(Storage storage)
        {
            Model = new LoginModel(storage);
            Name = string.Empty;
            Password = string.Empty;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = ReactiveCommand.Create(LoginExecute);
                }

                return _loginCommand;
            }
            set
            {
                _loginCommand = value;
                OnPropertyChanged();
            }
        }

        public ICommand SignUpCommand
        {
            get
            {
                if (_signUpCommand == null)
                {
                    _signUpCommand = ReactiveCommand.Create(SignUpExecute);
                }

                return _signUpCommand;
            }
            set
            {
                _signUpCommand = value;
                OnPropertyChanged();
            }
        }

        private void SignUpExecute()
        {
            Model.ShowSignUpWindow();
        }

        private bool SignUpCanExecute(object obj)
        {
            return true;
        }

        private void LoginExecute()
        {
            Model.Login(Name, Password);
        }

        private bool LoginCanExecute()
        {
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
