using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Pages.ViewModels;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.Cart
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public OrderDetailsCart orderDetailsCart { get; set; }
        
        public async Task<IActionResult> OnGet()
        {
            //Initialize OrderDetailsCart
            orderDetailsCart = new OrderDetailsCart();
            orderDetailsCart.OrderHeader = new OrderHeader();
            orderDetailsCart.OrderHeader.OrderTotal = 0;

            //get user ID
            ClaimsIdentity claimsIdentity = (ClaimsIdentity)this.User.Identity;

            Claim claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            string userId = claim.Value;

            var shoppingCart = _db.ShoppingCart.Where(c => c.ApplicationUserId == userId);

            if (shoppingCart == null) {
                return NotFound();
            }

            double totalPrice = 0;

            foreach (var shc in shoppingCart)
            {
                MenuItem currentMenuItem = await _db.MenuItems
                    .SingleOrDefaultAsync(mi => mi.Id == shc.MenuItemId);

                shc.MenuItem = currentMenuItem;
                totalPrice += (shc.MenuItem.Price * shc.Count);

                //Description up to 100 characters
                shc.MenuItem.Description = shc.MenuItem.Description.Substring(0, Math.Min(100, shc.MenuItem.Description.Length)) + ". . .";
            }

            //Set values to the OrderDetailsCart
            this.orderDetailsCart.ShoppingCart = shoppingCart.ToList();

            orderDetailsCart.OrderHeader.OrderTotal = totalPrice;
            orderDetailsCart.OrderHeader.OrderTotal = totalPrice;
            orderDetailsCart.OrderHeader.UserId = userId;
            orderDetailsCart.OrderHeader.User = (ApplicationUser)await _db.Users.SingleOrDefaultAsync(u => u.Id == userId);


            //Timing
            return Page();
        }

        public async Task<IActionResult> OnPost() {
            
            ClaimsIdentity claimsIdentity = (ClaimsIdentity)this.User.Identity;
            Claim claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string userId = claim.Value;

            orderDetailsCart.OrderHeader.UserId = userId;
            orderDetailsCart.OrderHeader.User = (ApplicationUser)await _db.Users.SingleOrDefaultAsync(u => u.Id == userId);


            var shoppingCart = _db.ShoppingCart.Where(c => c.ApplicationUserId == userId);

            if (shoppingCart == null)
            {
                return NotFound();
            }

            double totalPrice = 0;

            foreach (var shc in shoppingCart)
            {
                MenuItem currentMenuItem = await _db.MenuItems
                    .SingleOrDefaultAsync(mi => mi.Id == shc.MenuItemId);

                shc.MenuItem = currentMenuItem;
                totalPrice += (shc.MenuItem.Price * shc.Count);
            }

            this.orderDetailsCart.ShoppingCart = shoppingCart.ToList();
            
            orderDetailsCart.OrderHeader.OrderDate = DateTime.Now;
            orderDetailsCart.OrderHeader.Status = SD.StatusSubmited;

            OrderHeader orderHeader = orderDetailsCart.OrderHeader;

            await _db.OrderHeader.AddAsync(orderHeader);
            await _db.SaveChangesAsync();


            //Order Details
            foreach (var item in orderDetailsCart.ShoppingCart)
            {
                item.MenuItem = await _db.MenuItems.SingleOrDefaultAsync(mi => mi.Id == item.MenuItemId);

                OrderHeader orderHeaderFromDb = await _db.OrderHeader.SingleOrDefaultAsync(sh => sh.Id == orderHeader.Id);
                
                //Save Order In DB
                OrderDetails orderDetails = new OrderDetails()
                {
                    Count = item.Count,
                    Description = item.MenuItem.Description,
                    MenuItem = item.MenuItem,
                    MenuItemId = item.MenuItemId,
                    Name = item.MenuItem.Name,
                    Price = item.MenuItem.Price,
                    Order = orderHeaderFromDb,
                    OrderId = orderHeaderFromDb.Id
                };

                await _db.OrderDetails.AddAsync(orderDetails);
                await _db.SaveChangesAsync();
            }
            
            //Empty Shopping Cart
            List<ShoppingCart> shoppingCartCurrentUser = await _db.ShoppingCart.Where(sh => sh.ApplicationUserId == userId).ToListAsync();
            
            _db.ShoppingCart.RemoveRange(shoppingCartCurrentUser);

            await _db.SaveChangesAsync();
            
            HttpContext.Session.SetInt32(SD.CartCount, 0);

            string url = Url.Page("/Order/OrderConfirmation", new { orderId = orderHeader.Id });
            return LocalRedirect(url);
        }

        public async Task<IActionResult> OnGetIncreaseCount(int? cartId) {

            ShoppingCart cart = await _db.ShoppingCart.SingleOrDefaultAsync(c => c.Id == cartId);

            cart.Count++;

            await _db.SaveChangesAsync();
            
            return RedirectToPage(SD.Index);
        }

        public async Task<IActionResult> OnGetDecreaseCount(int? cartId)
        {
            ShoppingCart cart = await _db.ShoppingCart.SingleOrDefaultAsync(c => c.Id == cartId);

            cart.Count--;

            if (cart.Count < 1) {
                _db.ShoppingCart.Remove(cart);
                int cartCount = (int)HttpContext.Session.GetInt32("CartCount");

                //reset the session
                cartCount = cartCount - 1;
                HttpContext.Session.SetInt32("CartCount", (int)cartCount);
            }

            await _db.SaveChangesAsync();

            return RedirectToPage(SD.Index);
        }
    }
}