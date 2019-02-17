using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AvaloniaExample.Models;
using ReactiveUI;

namespace AvaloniaExample.ViewModels
{
    class SignUpViewModel: INotifyPropertyChanged
    {
        private string _name;
        private string _password;

        private ICommand _signUpCommand;

        public SignUpModel Model { get; private set; }

        public SignUpViewModel(Storage storage)
        {
            Model = new SignUpModel(storage);
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
            Model.SignUp(Name, Password);
        }

        private bool SignUpCanExecute(object obj)
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
