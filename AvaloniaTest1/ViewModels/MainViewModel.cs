using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AvaloniaExample.Models;

namespace AvaloniaExample.ViewModels
{
    class MainViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<UserModel> _users;

        public MainModel Model { get; private set; }

        public ObservableCollection<UserModel> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(Storage storage)
        {
            Users = new ObservableCollection<UserModel>();
            Model = new MainModel(storage);
            Model.UIUserAdded += UIOnUserAdded;
        }

        private void UIOnUserAdded(UserModel user)
        {
            Users.Add(user);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
