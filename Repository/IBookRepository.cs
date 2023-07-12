using BookAPI.models.Dto;

namespace BookAPI.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookDto>> GetProducts();
        Task<BookDto> GetProductById(int BookId);
        Task<BookDto> CreateUpdateProduct(BookDto BookId);
        Task<bool> DeleteProduct(int BookId);
    }
}
