using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.CategoryTypes
{
    [Authorize(Policy = SD.Admin)]      //We authorize only Admins to delete Category types
    public class DeleteModel : PageModel
    {
        
        private readonly ApplicationDbContext dbContext;
        
        public CategoryType categoryType { get; set; }

        public DeleteModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            this.categoryType = await this.dbContext.CategoryTypes.FindAsync(id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id) {
            
            if (id == null){
                return NotFound();
            }

            if (!ModelState.IsValid) {
                return Page();
            }

            CategoryType categoryType = await this.dbContext.CategoryTypes.FindAsync(id);

            if (categoryType == null){
                return NotFound();
            }

            this.dbContext.CategoryTypes.Remove(categoryType);

            await this.dbContext.SaveChangesAsync();

            return RedirectToPage("Index");
        }
        
    }
}