using WebEndpoint.Data.Entity;
using WebEndpoint.Domain.Contracts;

namespace BookAPI.Repository
{
    public interface IBookRepository : IRepository<Book,Guid>
    {

    }
}
