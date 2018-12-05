using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Pages.ViewModels;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.Order
{
    public class OrderPickupDetailsModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public OrderPickupDetailsModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public OrderTotalDetails OrderDetailsTotal { get; set; }

        public async Task<IActionResult> OnGet(int? orderId)
        {
            OrderDetailsTotal = new OrderTotalDetails();

            if (orderId == null)
            {
                return NotFound();
            }

            ClaimsIdentity claimIdentity = (ClaimsIdentity)this.User.Identity;

            Claim claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            string userId = claim.Value;

            this.OrderDetailsTotal.orderHeader = await _db.OrderHeader
                .Include(oh => oh.User)
                .SingleOrDefaultAsync(o => o.Id == orderId);

            if (OrderDetailsTotal.orderHeader == null)
            {
                return NotFound();
            }

            OrderDetailsTotal.orderDetailsList =_db.OrderDetails
                .Include(od => od.MenuItem)
                .ThenInclude(mi => mi.CategoryType)
                .Include(od => od.MenuItem)
                .ThenInclude(mi => mi.FoodType)
                .Where(od => od.OrderId == orderId).ToList();

            return Page();
        }

        public async Task<IActionResult> OnPost(int? orderId) {

            if (orderId == null)
            {
                return NotFound();
            }

            var currentOrderHeader = await _db.OrderHeader.SingleOrDefaultAsync(oh => oh.Id == orderId);

            currentOrderHeader.Status = SD.StatusCompleted;

            _db.OrderHeader.Update(currentOrderHeader);
            await _db.SaveChangesAsync();

            return RedirectToPage(SD.ManageOrder);
        }
    }
}