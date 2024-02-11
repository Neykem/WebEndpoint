using BookAPI.Repository;
using Microsoft.EntityFrameworkCore;
using WebEndpoint.Data;
using WebEndpoint.Data.Entity;
using WebEndpoint.Exception;

namespace WebEndpoint.Domain
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BookRepository> _logger;

        public BookRepository(ApplicationDbContext context, ILogger<BookRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<bool> CreateAsync(Book obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            try
            {
                await _context.Books.AddAsync(obj);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Ädd new entity in DB:" + obj.GetType());
            }
            catch (Exception ex)
            {
                _logger.LogError("Error for add new entity in DataBase: " + ex.Message);
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteAsync(Book obj)
        {
            try
            {
                if (obj == null)
                {
                    _logger.LogInformation("Call delete method from null odject:" + obj);
                    return false;
                }
                _logger.LogWarning("Call method for delete entity in DataBase:" + obj);
                _context.Books.Remove(obj);
                await _context.SaveChangesAsync();
                _logger.LogInformation($"{nameof(Book)} deleted");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error for delete entity from database: " + ex);
                return false;
            }
        }

        public async Task<List<Book>> GetAllAsync()
        {
            List<Book> booklist = await _context.Books.ToListAsync();
            if (booklist == null)
            {
                _logger.LogError("Return empty data collection from database");
                throw new ExceptionEmptyData();
            }
            _logger.LogInformation($"{nameof(GetAllAsync)} has been return");
            return booklist;
        }

        public async Task<Book> GetByIdAsync(Guid id)
        {
            var a = await _context.Books.Where(o => o.Id == id).FirstOrDefaultAsync();
            if (a == null)
            {
                _logger.LogInformation("Return empty req");
                return a;
            }
            _logger.LogInformation("Return result");
            return a;
        }

        public async Task<bool> UpdateAsync(Book obj)
        {
            _logger.LogWarning("Call update method for:" + $"{nameof(Book)} entity");
            if (obj == null)
            {
                _logger.LogInformation("Call update method with null object" + $"{nameof(Book)}");
                return false;
            }
            try
            {
                _context.Books.Update(obj);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Update entity: " + obj);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error update entity in Database" + ex);
                return false;
            }
        }
    }
}