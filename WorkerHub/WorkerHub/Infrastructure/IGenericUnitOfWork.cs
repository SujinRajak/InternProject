using System.Threading.Tasks;

namespace WorkerHub.Infrastructure
{
    public interface IGenericUnitOfWork 
    {
        IRepository<T> Repository<T>() where T:class;
        bool Commit();
        Task<bool> CommitAsync();
        IAsyncRepository<T> AsyncRepository<T>() where T : class;
    }
}
