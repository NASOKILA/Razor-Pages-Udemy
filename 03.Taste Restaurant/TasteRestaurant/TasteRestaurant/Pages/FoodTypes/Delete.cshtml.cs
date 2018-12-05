using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.FoodTypes
{
    [Authorize(Roles = SD.Admin)]  //Only users with Admin roles can access this page
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;

        public DeleteModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public FoodType foodType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!ModelState.IsValid){
                return Page();
            }

            if (id == null) {
                return NotFound();
            }

            this.foodType = await this.dbContext.FoodTypes.FindAsync(id);

            if (this.foodType == null) {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            this.dbContext.FoodTypes.Remove(this.foodType);

            await this.dbContext.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}