using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
    public class LibraryContext : DbContext
    {
        public virtual DbSet<Book> Books {get; set;}
        public virtual DbSet<Author> Authors {get; set;}
        public virtual DbSet<AuthorBook> AuthorBook {get; set;}

        public LibraryContext(DbContextOptions options) : base(options) { }
    }
}