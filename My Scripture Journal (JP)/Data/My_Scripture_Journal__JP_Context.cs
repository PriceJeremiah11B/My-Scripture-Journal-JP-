using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal__JP_.Models;

namespace My_Scripture_Journal__JP_.Data
{
    public class My_Scripture_Journal__JP_Context : DbContext
    {
        public My_Scripture_Journal__JP_Context (DbContextOptions<My_Scripture_Journal__JP_Context> options)
            : base(options)
        {
        }

        public DbSet<My_Scripture_Journal__JP_.Models.Book> Book { get; set; }
    }
}
