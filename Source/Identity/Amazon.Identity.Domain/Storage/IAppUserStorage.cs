namespace Amazon.Identity.Domain
{
    public interface IAppUserStorage
    {
        AppUser Get(string username);
        bool Update(AppUser user);
    }
}