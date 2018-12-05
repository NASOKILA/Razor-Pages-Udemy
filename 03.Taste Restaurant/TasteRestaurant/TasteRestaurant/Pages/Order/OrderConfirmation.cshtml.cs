using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Pages.ViewModels;

namespace TasteRestaurant.Pages.Order
{
    [Authorize]
    public class OrderConfirmationModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public OrderConfirmationModel(ApplicationDbContext db)
        {
            _db = db;
            OrderDetailsTotal = new OrderTotalDetails();
        }

        public OrderTotalDetails OrderDetailsTotal { get; set; }
        
        public async Task<IActionResult> OnGet(int? orderId)
        {
            if (orderId == null) {
                return NotFound();
            }

            ClaimsIdentity claimIdentity = (ClaimsIdentity)this.User.Identity;

            Claim claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            string userId = claim.Value;

            this.OrderDetailsTotal.orderHeader = await _db.OrderHeader
                .SingleOrDefaultAsync(o => o.Id == orderId && o.UserId == userId);

            if (OrderDetailsTotal.orderHeader == null){
                return NotFound();
            }

            OrderDetailsTotal.orderDetailsList = 
                _db.OrderDetails.Where(od => od.OrderId == orderId).ToList();
            
            return Page();
        }
    }
}