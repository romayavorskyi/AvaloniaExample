using System;
using AvaloniaExample.Managers;
using StarDebris.Avalonia.MessageBox;

namespace AvaloniaExample.Models
{
    class SignUpModel
    {
        private readonly Storage _storage;

        public SignUpModel(Storage storage)
        {
            _storage = storage;
        }

        public void SignUp(string login, string password)
        {
            if (String.IsNullOrEmpty(login))
            {
                Console.WriteLine("User login is empty");
                //MessageBox messageBox = new MessageBox("User login is empty");
                //messageBox.Show();
                return;
            }

            if (String.IsNullOrEmpty(password))
            {
                Console.WriteLine("User password is empty");
                //MessageBox messageBox = new MessageBox("User password is empty");
                //messageBox.Show();
                return;
            }

            if (_storage.Users.ContainsKey(login))
            {
                Console.WriteLine("User with entered login exists");
                //MessageBox messageBox = new MessageBox("User with entered login exists");
                //messageBox.Show();
                return;
            }

            _storage.AddUser(login, password);
            NavigationManager.Instance.Navigate(ModesEnum.Login);
        }
    }
}
