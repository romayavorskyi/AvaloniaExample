using System;
using AvaloniaExample.Managers;
using StarDebris.Avalonia.MessageBox;

namespace AvaloniaExample.Models
{
    public class LoginModel
    {
        private Storage _storage;

        public LoginModel(Storage storage)
        {
            _storage = storage;
        }

        public void ShowSignUpWindow()
        {
            NavigationManager.Instance.Navigate(ModesEnum.SingUp);
        }

        public void Login(string login, string password)
        {
            if (!_storage.Users.ContainsKey(login))
            {
                Console.WriteLine("Login or password is wrong");
                //MessageBox messageBox = new MessageBox("Login or password is wrong");
                //messageBox.Show();
            }
            else
            {
                if (_storage.Users[login].Password != password)
                {
                    Console.WriteLine("Login or password is wrong");
                    //MessageBox messageBox = new MessageBox("Login or password is wrong");
                    //messageBox.Show();
                }
                else
                {
                    NavigationManager.Instance.Navigate(ModesEnum.Main);
                }
            }
        }
    }
}
