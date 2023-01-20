namespace Amazon.Identity.Domain
{
    public interface IAppUserManager
    {
        bool CreateNew(AppUser user);
    }
}