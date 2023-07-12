using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WebEndpoint.Data;
using WebEndpoint.Endpoints.CatalogEndpoints.CatalogResult;

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

        public Task<bool> CreateAsync(Book obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Book odj)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetAllAsync()
        {
            List<Book> booklist = await _context.Books.ToListAsync();
            return (List<Book>)_mapper.Map<IEnumerable<BookResult>>(booklist);
        }

        public Task<Book> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Book obj)
        {
            throw new NotImplementedException();
        }

        //public async Task<BookResult> CreateUpdateProduct(Book bookObj)
        //{
        //    Book book = _mapper.Map<Book,BookResult>(book);
        //    if (book.BookId > 0)
        //    {
        //        _context.Books.Update(book);
        //    }
        //    else
        //    {
        //        _context.Books.Add(book);
        //    }
        //    await _context.SaveChangesAsync();
        //    return _mapper.Map<Book, BookDto>(book);
        //}

        //public async Task<bool> DeleteAsync(Book odj)
        //{
        //    try
        //    {
        //        Book book = await _context.Books.FirstOrDefaultAsync(u => u.BookId == bookId);
        //        if (book == null)
        //        {
        //            return false;
        //        }
        //        _context.Books.Remove(book);
        //        await _context.SaveChangesAsync();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}



        //public Task<List<Book>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Book> GetByIdAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<BookDto> GetProductById(int bookId)
        //{
        //    Book product = await _context.Books.Where(x => x.BookId == bookId).FirstOrDefaultAsync();
        //    return _mapper.Map<BookDto>(product);
        //}

        //public async Task<IEnumerable<BookDto>> GetProducts()
        //{
        //    List<Book> booklist = await _context.Books.ToListAsync();
        //    return _mapper.Map<IEnumerable<BookDto>>(booklist);
        //}

        //public Task<bool> UpdateAsync(Book obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
