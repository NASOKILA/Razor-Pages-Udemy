using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.CategoryTypes
{

    [Authorize(Policy = SD.Admin)]      //We authorize only Admins to create Category types
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;

        [BindProperty]
        public CategoryType categoryType { get; set; }
        
        public CreateModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            
        }

        public IActionResult OnGetAsync() {
            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync() {

            
            if (!ModelState.IsValid) {
                return Page();
            }
            
            await this.dbContext.CategoryTypes.AddAsync(this.categoryType);

            await this.dbContext.SaveChangesAsync();

            //return RedirectToPage("./Index");
            return RedirectToPage("Index");
        }
    }
}