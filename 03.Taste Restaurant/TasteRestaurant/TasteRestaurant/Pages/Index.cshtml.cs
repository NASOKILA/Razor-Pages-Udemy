using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Pages.ViewModels;

namespace TasteRestaurant.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
            this.Message = string.Empty;
        }

        [BindProperty]
        public IndexViewModel indexViewModel { get; set; }

        [TempData]
        public string Message { get; set; }

        public async Task OnGet()
        {

            this.indexViewModel = new IndexViewModel()
            {
                MenuItems = await _db.MenuItems.Include(m => m.CategoryType).Include(m => m.FoodType).ToListAsync(),
                CategoryTypes = await _db.CategoryTypes.OrderBy(c => c.DisplayOrder).ToListAsync()
            };

        }
    }
}
