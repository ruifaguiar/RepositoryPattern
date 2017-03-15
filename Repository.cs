namespace RepositoryTests
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public virtual void Open()
        {
            //implement method to save 

        }
        public virtual void Save()
        {
            
        }
    }
}