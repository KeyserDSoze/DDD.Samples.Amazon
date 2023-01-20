namespace Amazon.Identity.Domain
{
    internal sealed class AppUserManager : IAppUserManager
    {
        private readonly IAppUserStorage _storage;
        private readonly IAppCache<AppUser>? _appCache;

        public AppUserManager(IAppUserStorage storage, IAppCache<AppUser>? appCache = null)
        {
            _storage = storage;
            _appCache = appCache;
        }
        public bool CreateNew(AppUser user)
        {
            if (!user.Username.StartsWith("."))
                return _storage.Update(user);
            return false;
        }
        public AppUser Get(string username)
        {
            if(_appCache != null && _appCache.Exists(username))
                return _appCache.Get(username);
            else
            {
                var user = _storage.Get(username);
                if (_appCache != null)
                    _appCache.Set(user.Username, user);
                return user;
            }
        }
    }
}