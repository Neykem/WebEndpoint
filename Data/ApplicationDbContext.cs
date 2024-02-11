using Microsoft.EntityFrameworkCore;
using WebEndpoint.Data.Entity;

namespace WebEndpoint.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {

        }
    }
}
