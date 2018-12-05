using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.FoodTypes
{
    [Authorize(Roles = SD.Admin)]  //Only users with Admin roles can access this page
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;

        public DetailsModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public FoodType foodType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null){
                return NotFound();
            }
            
            this.foodType = await dbContext.FoodTypes.FindAsync(id);

            if (this.foodType == null){
                return NotFound();
            }

            return Page();
        }
    }
}