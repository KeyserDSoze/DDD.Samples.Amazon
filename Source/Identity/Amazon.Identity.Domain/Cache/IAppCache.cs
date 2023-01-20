namespace Amazon.Identity.Domain
{
    public interface IAppCache<T>
    {
        T Get(string key);
        bool Set(string key, T entity);
        bool Exists(string key);
    }
}