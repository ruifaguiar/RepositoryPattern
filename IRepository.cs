namespace RepositoryTests
{
    public interface IRepository<T>
    {
       void Save();
       void Open(); 
    }
}