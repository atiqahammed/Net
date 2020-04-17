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

        public CreateModel(ApplicationDBContext _db)
        {
            this._db = _db;
        }

        public Book Book { get; set; }
        public void OnGet()
        {

        }
    }
}