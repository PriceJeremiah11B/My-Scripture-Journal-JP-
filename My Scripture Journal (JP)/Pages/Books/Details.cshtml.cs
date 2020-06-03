using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal__JP_.Data;
using My_Scripture_Journal__JP_.Models;

namespace My_Scripture_Journal__JP_.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly My_Scripture_Journal__JP_.Data.My_Scripture_Journal__JP_Context _context;

        public DetailsModel(My_Scripture_Journal__JP_.Data.My_Scripture_Journal__JP_Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
