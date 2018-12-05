using System.Collections.Generic;
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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ICollection<MenuItem> MenuItemsList { get; set; }

        public async Task<IActionResult> OnGet()
        {
            MenuItemsList = await _dbContext.MenuItems
                .Include(mi => mi.CategoryType)
                .Include(mi => mi.FoodType)
                .ToListAsync();

            return Page();
        }
    }
}