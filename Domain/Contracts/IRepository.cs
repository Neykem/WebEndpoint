using WebEndpoint.Endpoints.CatalogEndpoints;

namespace WebEndpoint.Domain.Contracts
{
    public interface IRepository<T, R> where T : class
    {
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(R id);
        public Task<bool> DeleteAsync(T odj);
        public Task<bool> CreateAsync(T obj);
        public Task<bool> UpdateAsync(T obj);
    }
}
