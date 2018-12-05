using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_RazorPages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_RazorPages.Pages.BookList
{
    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext dbContext;

        public EditModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Book Book { get; set; }
        
        public void OnGet(int id)
        {
            Book book = dbContext.Books.Find(id);
            
            this.Book = book;
        }

        public async Task<IActionResult> OnPost(int id) {

            if (!ModelState.IsValid) {
                return Page();
            }

            this.Book.Id = id;

            this.dbContext.Books.Update(this.Book);

            await dbContext.SaveChangesAsync();

            this.Message = "Book was updated successfully !";

            return RedirectToPage("Index");
        }
            
    }
}