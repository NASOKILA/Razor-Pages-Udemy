using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.MenuItems
{
    [Authorize(Roles = SD.Admin)]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHostingEnvironment _hostingEnvironment;

        public DeleteModel(ApplicationDbContext dbContext, IHostingEnvironment hostingEnvironment)
        {
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment;
        }
        
        public MenuItem menuItem { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MenuItem menuItem = await this._dbContext
                .MenuItems
                .Include(mi => mi.CategoryType)
                .Include(mi => mi.FoodType)
                .SingleOrDefaultAsync(mi => mi.Id == id);

            if (menuItem == null)
            {
                return NotFound();
            }

            this.menuItem = menuItem;            

            return Page();
        }

        public async Task<IActionResult> OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MenuItem menuItem = await _dbContext.MenuItems.SingleOrDefaultAsync(mi => mi.Id == id);

            if (menuItem == null)
            {
                return NotFound();
            }


            //Delete image from server if exists.
            var wwwRootPath =_hostingEnvironment.WebRootPath;
            var uploads = Path.Combine(wwwRootPath, "images");
            int indexOfDot = menuItem.Image.LastIndexOf(".");
            string extensionOfUploadedFile = menuItem.Image.Substring(indexOfDot, menuItem.Image.Length - indexOfDot);
            var imagePath = Path.Combine(uploads, menuItem.Id + extensionOfUploadedFile);
            if (System.IO.File.Exists(imagePath)) {
                System.IO.File.Delete(imagePath);
            }


            _dbContext.MenuItems.Remove(menuItem);

            await _dbContext.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}