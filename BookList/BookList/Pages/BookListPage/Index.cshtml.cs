using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookList.Pages.BookListPage
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDBContext _db;
        public IEnumerable<Book> Books;
        public IndexModel(ApplicationDBContext _db)
        {
            this._db = _db;
        }

        public async Task OnGet()
        {
            Books = await this._db.Book.ToListAsync();
        }
    }
}