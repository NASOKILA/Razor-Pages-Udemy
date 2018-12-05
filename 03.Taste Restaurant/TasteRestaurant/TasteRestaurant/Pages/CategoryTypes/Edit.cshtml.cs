using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.CategoryTypes
{
    [Authorize(Policy = SD.Admin)]      //We authorize only Admins to edit Category types
    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext dbContext;

        public EditModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public CategoryType categoryType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id){

            if (id == null)
            {
                return NotFound();
            }

            this.categoryType = await this.dbContext.CategoryTypes.FindAsync(id);

            return Page();
        }


        public async Task<IActionResult> OnPostAsync() {
            
            if (!ModelState.IsValid) {
                return Page();
            }

            
            this.dbContext.CategoryTypes.Update(this.categoryType);
            
            //I taka stawa
            //this.dbContext.Attach(this.categoryType).State = EntityState.Modified;
            
            await this.dbContext.SaveChangesAsync();
            
            return RedirectToPage("Index");
        }

    }
}



