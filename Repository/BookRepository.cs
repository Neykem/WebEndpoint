using AutoMapper;
using BookAPI.Data;
using BookAPI.models;
using BookAPI.models.Dto;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public BookRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BookDto> CreateUpdateProduct(BookDto bookDto)
        {
            Book book = _mapper.Map<BookDto, Book>(bookDto);
            if (book.BookId > 0)
            {
                _context.Books.Update(book);
            }
            else
            {
                _context.Books.Add(book);
            }
            await _context.SaveChangesAsync();
            return _mapper.Map<Book, BookDto>(book);
        }

        public async Task<bool> DeleteProduct(int bookId)
        {
            try
            {
                Book book = await _context.Books.FirstOrDefaultAsync(u => u.BookId == bookId);
                if (book == null)
                {
                    return false;
                }
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<BookDto> GetProductById(int bookId)
        {
            Book product = await _context.Books.Where(x => x.BookId == bookId).FirstOrDefaultAsync();
            return _mapper.Map<BookDto>(product);
        }

        public async Task<IEnumerable<BookDto>> GetProducts()
        {
            List<Book> booklist = await _context.Books.ToListAsync();
            return _mapper.Map<IEnumerable<BookDto>>(booklist);
        }
    }
}
