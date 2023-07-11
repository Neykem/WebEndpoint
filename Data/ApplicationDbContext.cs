using Microsoft.EntityFrameworkCore;

namespace WebEndpoint.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        public DbSet<Book> Books { get; set; } 
    }
}
