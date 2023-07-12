using WebEndpoint.Data;
using WebEndpoint.Domain.Contracts;

namespace BookAPI.Repository
{
    public interface IBookRepository : IRepository<Book,Guid>
    {

    }
}
