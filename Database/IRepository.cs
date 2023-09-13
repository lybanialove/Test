namespace WebApplication1.Database
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        Task<IEnumerable<T>> GetList();
        Task<T> Get(int id);
        Task<T> Create(T entity);
        Task Delete(int id);
        Task Update(T entity);
    }
}
