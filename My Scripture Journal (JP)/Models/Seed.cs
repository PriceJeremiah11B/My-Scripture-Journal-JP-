using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using My_Scripture_Journal__JP_.Data;


namespace My_Scripture_Journal__JP_.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new My_Scripture_Journal__JP_Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<My_Scripture_Journal__JP_Context>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        BookName = "Alma ",
                        DateAdded = DateTime.Parse("2020-3-22"),
                        Chapter = 3,
                        Verse = 25,
                        Notes = "Reminds me of the Old Testament chapter about war."
                    },

                    new Book
                    {
                        BookName = "Alma ",
                        DateAdded = DateTime.Parse("2020-3-22"),
                        Chapter = 4,
                        Verse = 25,
                        Notes = "Reminds me of the Old Testament chapter about war."
                    },

                    new Book
                    {
                        BookName = "Alma ",
                        DateAdded = DateTime.Parse("2020-3-22"),
                        Chapter = 12,
                        Verse = 25,
                        Notes = "Reminds me of the Old Testament chapter about war."
                    },

                    new Book
                    {
                        BookName = "Alma ",
                        DateAdded = DateTime.Parse("2020-3-22"),
                        Chapter = 32,
                        Verse = 25,
                        Notes = "Reminds me of the Old Testament chapter about war."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
