using System.Collections.Concurrent;

namespace Amazon.Identity.Domain
{
    internal sealed class AppUserStorage : IAppUserStorage
    {
        private readonly ConcurrentDictionary<string, AppUser> _users = new();
        public AppUser Get(string username)
            => _users[username];

        public bool Update(AppUser user)
        {
            if (_users.ContainsKey(user.Username))
                _users[user.Username] = user;
            else
                _users.TryAdd(user.Username, user);
            return true;
        }
    }
}