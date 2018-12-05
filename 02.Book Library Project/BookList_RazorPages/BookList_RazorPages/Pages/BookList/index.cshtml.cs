using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_RazorPages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookList_RazorPages.Pages.Books
{
    public class indexModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;

        public indexModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        //This is a property which we can pass to the front file and display it's value.
        public string SomeData { get; set; }

        public IEnumerable<Book> Books { get; set; }

        [TempData] //This Property corrisponds to the one in the Create page !
        public string Message { get; set; }

        //This method runs on a GET request
        public async Task OnGet()
        {
            //To gt the books asincronously we need to do it like this :
            this.Books = await this.dbContext.Books.ToListAsync();
            
            SomeData = "Hello From PageModel :)";
        }



        //We create a new HANDLER for deleting books, IT HAS TO START WITH "OnPost", It receives the Book Id
        public async Task<IActionResult> OnPostDelete (int id) {

            Book currentBook = await dbContext.Books.FindAsync(id);

            this.dbContext.Books.Remove(currentBook);

            await dbContext.SaveChangesAsync();

            //Change the Message property
            this.Message = "Book Deleted Successfully !";

            //We redirect to this same page
            return RedirectToPage();
        }

    }
}