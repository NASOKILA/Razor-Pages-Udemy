using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.CategoryTypes
{

    [Authorize(Policy = SD.Admin)]      //We authorize only Admins to show Details Category page
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;

        public DetailsModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public CategoryType categoryType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            this.categoryType = await this.dbContext.CategoryTypes.FindAsync(id);

            return Page();
        }

    }
}