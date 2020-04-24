using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookList.Model;

namespace BookList.Pages.BookListPage
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public bool IsUpdating = false;

        public CreateModel(ApplicationDBContext _db)
        {
            this._db = _db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(long Id)
        {
            Book = await _db.Book.FindAsync(Id);
            if(Book != null)
            {
                IsUpdating = true;
            }
            
        }

        public async Task<IActionResult> OnPost()
        {



            if (ModelState.IsValid && !IsUpdating)
            {
                await _db.AddAsync(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else if(ModelState.IsValid && IsUpdating)
            {
                var BookFromDB = await _db.Book.FindAsync(Book.Id);
                BookFromDB.Name = Book.Name;
                BookFromDB.Author = Book.Author;
                BookFromDB.ISBN = Book.ISBN;

                Book = null;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}