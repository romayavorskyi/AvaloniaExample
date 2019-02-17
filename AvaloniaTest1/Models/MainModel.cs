using System;

namespace AvaloniaExample.Models
{
    public class MainModel
    {
        private Storage _storage;

        public event Action<UserModel> UIUserAdded;

        public MainModel(Storage storage)
        {
            _storage = storage;
            storage.UserAdded += OnUserAdded;
        }

        private void OnUserAdded(UserModel userModel)
        {
            UIUserAdded?.Invoke(userModel);
        }
    }
}
