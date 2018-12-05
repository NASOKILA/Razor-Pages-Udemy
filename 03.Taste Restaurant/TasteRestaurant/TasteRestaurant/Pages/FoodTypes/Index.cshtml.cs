using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.FoodTypes
{
    [Authorize(Roles = SD.Admin)]  //Only users with Admin roles can access this page
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;

        public IndexModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ICollection<FoodType> foodTypesList { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            this.foodTypesList = await this.dbContext.FoodTypes.ToListAsync();

            return Page();
        }   
    }
}