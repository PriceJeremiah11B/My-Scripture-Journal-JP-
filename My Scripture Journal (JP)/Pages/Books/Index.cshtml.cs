using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal__JP_.Data;
using My_Scripture_Journal__JP_.Models;

namespace My_Scripture_Journal__JP_.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly My_Scripture_Journal__JP_.Data.My_Scripture_Journal__JP_Context _context;

        public IndexModel(My_Scripture_Journal__JP_.Data.My_Scripture_Journal__JP_Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList BookName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string BookNameList { get; set; }



        public async Task OnGetAsync()
        {
            IQueryable<string> genreQuery = from m in _context.Book
                                            orderby m.BookName
                                            select m.Book;

            var books = from m in _context.Book
                        orderby m.BookName
                        select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.BookName.Contains(SearchString));

            }
            books = new SelectList(await booksQuery.Distinct().ToListAsync());
            Book = await _context.Book.ToListAsync();
        }
    }
}
