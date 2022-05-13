using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookListRazorPages.Book;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazorPages.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db; //dependency injection
        }

        public IEnumerable<Book.Book> Books { get; set; }

        public async Task OnGet()
        {
            //getting all the books from db
            //async - run multiple tasks 
            Books = await _db.Book.ToListAsync();
        }
    }
}
