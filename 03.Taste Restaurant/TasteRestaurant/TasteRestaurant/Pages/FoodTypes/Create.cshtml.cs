using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.FoodTypes
{

    [Authorize(Roles = SD.Admin)]  //Only users with Admin roles can access this page
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext dbContext;

        public CreateModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public FoodType foodType { get; set; }

        public void OnGet()
        {
            System.Console.WriteLine();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) {
                return Page();
            }

            await this.dbContext.FoodTypes.AddAsync(this.foodType);

            await dbContext.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}