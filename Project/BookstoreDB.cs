using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project
{
    public class BookstoreDb : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookstoreDb(DbContextOptions<BookstoreDb> options) : base(options)
        {
        }
    }
}


