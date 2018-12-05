using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;

namespace TasteRestaurant.Pages
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DetailsModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public ShoppingCart CartObj { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {

            //if (!this.User.Identity.IsAuthenticated)
            //{
            //    string url = Url.Page("/Account/Login", new { area = "Identity" });
            //    return LocalRedirect(url);
            //}
            //WE DONT NEED THE THIS CODE BECAUSE WE ALREADY HAVE THE ATTRIBUTE [Authorize] FOR 
            //CHECKING THE AUTHORIZATION

            if (id == null)
            {
                return NotFound();
            }

            MenuItem menuItem = await _db.MenuItems
                .Include(mi => mi.FoodType)
                .Include(mi => mi.CategoryType)
                .SingleOrDefaultAsync(mi => mi.Id == id);

            if (menuItem == null)
            {
                return NotFound();
            }

            ApplicationUser curentUser = await _db.Users
                .SingleOrDefaultAsync(u => u.Email == this.User.Identity.Name) as ApplicationUser;

            if (curentUser == null)
            {
                return NotFound();
            }

            CartObj = new ShoppingCart
            {
                MenuItem = menuItem,
                MenuItemId = menuItem.Id,
                ApplicationUser = curentUser,
                ApplicationUserId = curentUser.Id
            };

            return Page();
        }

        public async Task<IActionResult> OnPost(int? id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("Details", new { id = id});
            }
            
            //Get User Id from claim
            ClaimsIdentity claimsIdentity = this.User.Identity as ClaimsIdentity;

            Claim claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            string userId = claim.Value;

            //set the current user id to the cartObj
            CartObj.ApplicationUserId = userId;

            ShoppingCart CartFromDb = await _db.ShoppingCart.SingleOrDefaultAsync(
                shc => shc.ApplicationUserId == CartObj.ApplicationUserId
                && shc.MenuItemId == CartObj.MenuItemId);

            if (CartFromDb == null)
            {
                //if we add a product for the first time then the cart is null because it does not exist

                //we create the cart
                await _db.ShoppingCart.AddAsync(CartObj);
            }
            else
            {
                //Here the cart already exist so we update the count
                CartFromDb.Count += CartObj.Count;
            }

            await _db.SaveChangesAsync();


            //Add Sesion and increment count, we will store only the cart number integer 

            //Get all cart objects for this user
            List<ShoppingCart> userCartItems = await _db.ShoppingCart.Where(c => c.ApplicationUserId == userId).ToListAsync();

            //store the count into the session
            HttpContext.Session.SetInt32("CartCount", userCartItems.Count);

            this.Message = "Item added to the cart successfully !";

            return RedirectToPage("Index");
        }
    }
}