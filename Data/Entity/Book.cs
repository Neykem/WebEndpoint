using System.ComponentModel.DataAnnotations;

namespace WebEndpoint.Data.Entity
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}