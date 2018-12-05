using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_RazorPages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_RazorPages.Pages.BookList
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext dbContext;

        public CreateModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [TempData] // This is a way to pass a message to another page, in this case we will pass it to the Index page !
        public string Message { get; set; }

        [BindProperty]  // Now it will refere to the new Book from our form.
        public Book Book { get; set; }

        public void OnGet()
        {}
 
        //We create an async post handler
        public async Task<IActionResult> OnPost()
        {

            //The first thing we check is the ModelState
            
            if (!ModelState.IsValid)
            {
                return Page();        
            }

            //Add the book
            this.dbContext.Books.Add(this.Book);

            //save changes async
            await this.dbContext.SaveChangesAsync();

            //We set the message property which has a [TempData] attribute
            this.Message = "Book added successfuly !";

            //redirect to the Index page
            return RedirectToPage("Index");

        }
    }
}