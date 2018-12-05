using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Pages.ViewModels;

namespace TasteRestaurant.Pages.Order
{
    public class OrderHistoryModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public OrderHistoryModel(ApplicationDbContext db)
        {
            _db = db;
            orderTotalDetails = new List<OrderTotalDetails>();
        }

        public List<OrderTotalDetails> orderTotalDetails { get; set; }

        public bool Loaded { get; set; }

        public async Task<IActionResult> OnGet(int num=0)
        {
            ClaimsIdentity claimIdentity = (ClaimsIdentity)this.User.Identity;

            Claim claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            string userId = claim.Value;

            var orderHeaderList = await _db.OrderHeader
                .Where(od => od.UserId == userId)
                .OrderByDescending(hl => hl.OrderDate)
                .ToListAsync();
            
            foreach (var oh in orderHeaderList)
            {
                List<OrderDetails> orderDetails = _db.OrderDetails
                    .Where(od => od.OrderId == oh.Id)
                    .ToList();

                orderTotalDetails.Add(new OrderTotalDetails() {orderDetailsList = orderDetails, orderHeader = oh });
            }

            if (num == 0)
            {
                orderTotalDetails = orderTotalDetails.Take(5).ToList();
                Loaded = false;
            }
            else {
                Loaded = true;
            }

            return Page();
        }
    }
}