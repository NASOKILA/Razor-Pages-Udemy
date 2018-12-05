using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.CategoryTypes
{
    [Authorize(Policy = SD.Admin)]      //We authorize only Admins to show Category types
    public class IndexModel : PageModel
    {
        public ApplicationDbContext dbContext { get; set; }

        public IndexModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<CategoryType> categoryTypes { get; set; }

        public async Task<IActionResult> OnGet()
        {
            this.categoryTypes = await this.dbContext.CategoryTypes
                                                .OrderBy(c => c.DisplayOrder)
                                                .ToListAsync();

            return Page();
        }
    }
}