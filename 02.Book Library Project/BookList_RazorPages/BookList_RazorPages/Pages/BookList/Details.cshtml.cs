using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookList_RazorPages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList_RazorPages.Pages.BookList
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;

        public DetailsModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Book Book { get; set; }

        public void OnGet(int id)
        {
            this.Book = dbContext.Books.Find(id);
        }
    }
}