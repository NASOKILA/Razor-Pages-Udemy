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
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        private readonly IHostingEnvironment _hotingEnvironment; // This is for hosting the image on the server

        public CreateModel(ApplicationDbContext dbContext, IHostingEnvironment hotingEnvironment)
        {
            _dbContext = dbContext;
            _hotingEnvironment = hotingEnvironment;
        }

        [BindProperty]
        public MenuItemViewModel menuItemViewModel { get; set; }

        public IActionResult OnGet()
        {
            this.menuItemViewModel = new MenuItemViewModel()
            {
                categoryTypes = _dbContext.CategoryTypes.ToList(),
                foodTypes = _dbContext.FoodTypes.ToList(),
                menuItem = new MenuItem()
            };

            return Page();
        }

        public async Task<IActionResult> OnPost(MenuItemViewModel menuItemViewModel)
        {
            if (!ModelState.IsValid) {

                this.menuItemViewModel = new MenuItemViewModel()
                {
                    categoryTypes = await _dbContext.CategoryTypes.ToListAsync(),
                    foodTypes = await _dbContext.FoodTypes.ToListAsync(),
                    menuItem = menuItemViewModel.menuItem
                };

                return Page();
            }


            CategoryType categoryType = await _dbContext.CategoryTypes.SingleOrDefaultAsync(ct => ct.Name == menuItemViewModel.menuItem.CategoryType.Name);

            if (categoryType == null) {

                this.menuItemViewModel = new MenuItemViewModel()
                {
                    categoryTypes = await _dbContext.CategoryTypes.ToListAsync(),
                    foodTypes = await _dbContext.FoodTypes.ToListAsync(),
                    menuItem = menuItemViewModel.menuItem
                };

                return Page();
            }

            FoodType foodType = await _dbContext.FoodTypes
                .SingleOrDefaultAsync(ft => ft.Name == menuItemViewModel.menuItem.FoodType.Name);

            if (foodType == null)
            {
                this.menuItemViewModel = new MenuItemViewModel()
                {
                    categoryTypes = await _dbContext.CategoryTypes.ToListAsync(),
                    foodTypes = await _dbContext.FoodTypes.ToListAsync(),
                    menuItem = menuItemViewModel.menuItem
                };

                return Page();
            }

            MenuItem menuItem = menuItemViewModel.menuItem;

            menuItem.CategoryType = categoryType;

            menuItem.FoodType = foodType;
            
            await _dbContext.MenuItems.AddAsync(menuItem);

            await _dbContext.SaveChangesAsync();


            //Save the image 

            //get the path of wwwRoot folder
            string webRootPath = _hotingEnvironment.WebRootPath;

            //get the uploaded file
            var files = HttpContext.Request.Form.Files;
            

            //get the menuitem that we just added
            MenuItem currentMenuItem = await _dbContext.MenuItems.FindAsync(menuItemViewModel.menuItem.Id);

            
            //check if a file has being uploaded 
            if (files != null && files.Count > 0 && files[0].Length > 0)
            {

                //we combine the path with the image path
                //the upload variable now has the path for the images folder
                var upload = Path.Combine(webRootPath, "images");


                //we take the extension of the file we uploaded
                int indexOfDot = files[0].FileName.LastIndexOf(".");
                string extensionOfUploadedFile = files[0].FileName.Substring(indexOfDot, files[0].FileName.Length - indexOfDot);


                //We just copy the file into the inameg folder
                using (FileStream fileStream = new FileStream(Path.Combine(upload, menuItemViewModel.menuItem.Id + extensionOfUploadedFile), FileMode.Create))
                {
                    //We copy it to the images folder
                    files[0].CopyTo(fileStream);
                }


                //After copying it into the folder we need to change if for the actual menuItem
                currentMenuItem.Image = @"\images\" + menuItemViewModel.menuItem.Id + extensionOfUploadedFile;

            }
            else
            {
                string uploads = webRootPath + "/images/"+ SD.DefaultMenuItemImage;
                System.IO.File.Copy(uploads, webRootPath + @"/images/" + menuItemViewModel.menuItem.Id + ".jpg");

                //if something goes wrong we set the default image
                currentMenuItem.Image = @"\images\" + menuItemViewModel.menuItem.Id + ".jpg";


            }

            _dbContext.MenuItems.Update(currentMenuItem);

            await _dbContext.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}