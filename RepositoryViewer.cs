namespace RepositoryTests
{
    public class RepositoryViewer : Repository<ViewerSettings>, IRepositoryViewer
    {
        public override void Save()
        {
            base.Save();
        }
    }
}