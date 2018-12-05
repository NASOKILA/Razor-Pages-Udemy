using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.MenuItems
{
    [Authorize(Roles = SD.Admin)]
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public DetailsModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public MenuItem menuItem { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            MenuItem menuItem = await _dbContext.MenuItems
                .Include(mi => mi.CategoryType)
                .Include(mi => mi.FoodType)
                .SingleOrDefaultAsync(mi => mi.Id == id);

            if (menuItem == null) {
                return NotFound();
            }

            this.menuItem = menuItem;

            return Page();
        }
    }
}