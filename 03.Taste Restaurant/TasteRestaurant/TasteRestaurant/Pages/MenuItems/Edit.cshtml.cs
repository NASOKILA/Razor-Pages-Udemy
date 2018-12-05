using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Pages.ViewModels;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.MenuItems
{
    [Authorize(Roles = SD.Admin)]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        private readonly IHostingEnvironment _hostingEnvironment;

        public EditModel(ApplicationDbContext dbContext, IHostingEnvironment hostingEnvironment)
        {
            _dbContext = dbContext;
            _hostingEnvironment = hostingEnvironment; 
        }

        [BindProperty]
        public MenuItemViewModel menuItemViewModel { get; set; }
        
        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MenuItem menuItem = await this._dbContext.MenuItems
                .Include(mi => mi.CategoryType)
                .Include(mi => mi.FoodType)
                .SingleOrDefaultAsync(mi => mi.Id == id);

            if (menuItem == null)
            {
                return NotFound();
            }

            this.menuItemViewModel = new MenuItemViewModel
            {
                categoryTypes = await _dbContext.CategoryTypes.ToListAsync(),
                foodTypes = await _dbContext.FoodTypes.ToListAsync(),
                menuItem = menuItem
            };

            return Page();
        }
        
        public async Task<IActionResult> OnPost(MenuItemViewModel menuItemViewModel) {
            
            MenuItem menuItem = _dbContext.MenuItems.SingleOrDefault(mi => mi.Id == menuItemViewModel.menuItem.Id);
            string oldImage = menuItem.Image;

            menuItem.Name = menuItemViewModel.menuItem.Name;

            menuItem.Price = menuItemViewModel.menuItem.Price;

            menuItem.Description = menuItemViewModel.menuItem.Description;

            menuItem.Spicyness = menuItemViewModel.menuItem.Spicyness;
            
            CategoryType categoryType = await _dbContext
                .CategoryTypes
                .SingleOrDefaultAsync(ct => ct.Name == menuItemViewModel.menuItem.CategoryType.Name);

            FoodType foodType = await _dbContext
                .FoodTypes
                .SingleOrDefaultAsync(ct => ct.Name == menuItemViewModel.menuItem.FoodType.Name);
            
            if (categoryType == null || foodType == null) {
                return NotFound();
            }
            
            menuItem.CategoryType = categoryType;

            menuItem.FoodType = foodType;
            
            //Change the image

            //get the path of wwwRoot folder
            string webRootPath = _hostingEnvironment.WebRootPath;

            //get the uploaded file
            var files = HttpContext.Request.Form.Files;
            
            //check if a file has being uploaded 
            if (files != null && files.Count > 0 && files[0].Length > 0)
            {

                //we combine the path with the image path
                //the upload variable now has the path for the images folder
                var imagesFolder = Path.Combine(webRootPath, "images");

                //we take the extension of the file we uploaded
                int indexOfDot = files[0].FileName.LastIndexOf(".");
                string extensionOfUploadedFile = files[0].FileName.Substring(indexOfDot, files[0].FileName.Length - indexOfDot);
                
                //We just copy the file into the inameg folder
                using (FileStream fileStream = new FileStream(Path.Combine(imagesFolder, menuItemViewModel.menuItem.Id + extensionOfUploadedFile), FileMode.Create))
                {
                    //We copy it to the images folder
                    files[0].CopyTo(fileStream);
                }

                //After copying it into the folder we need to change if for the actual menuItem
                menuItem.Image = @"\images\" + menuItemViewModel.menuItem.Id + extensionOfUploadedFile;
            }
            else
            {
                menuItem.Image = oldImage;
            }

            _dbContext.MenuItems.Update(menuItem);

            await _dbContext.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}