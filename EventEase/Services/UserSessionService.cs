using EventEase.Models;

namespace EventEase.Services
{
    public class UserSessionService
    {
        private readonly List<UserModel> _registeredUsers = new();

        public UserModel? CurrentUser { get; private set; }

        public event Action? OnUserChanged;

        public void Register(UserModel user)
        {
            if (!_registeredUsers.Any(u => u.Email == user.Email))
            {
                user.Id = _registeredUsers.Count + 1;
                _registeredUsers.Add(user);
            }
            Login(user);
        }

        public bool Login(string email, string password)
        {
            var user = _registeredUsers.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                CurrentUser = user;
                CurrentUser.IsLoggedIn = true;
                OnUserChanged?.Invoke();
                return true;
            }
            return false;
        }

        public void Login(UserModel user)
        {
            CurrentUser = user;
            CurrentUser.IsLoggedIn = true;
            OnUserChanged?.Invoke();
        }

        public void Logout()
        {
            CurrentUser = null;
            OnUserChanged?.Invoke();
        }
    }
}

