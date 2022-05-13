using Microsoft.EntityFrameworkCore;

namespace BookListRazorPages.Book
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
         
        public DbSet<Book> Book { get; set; }


    }
}
