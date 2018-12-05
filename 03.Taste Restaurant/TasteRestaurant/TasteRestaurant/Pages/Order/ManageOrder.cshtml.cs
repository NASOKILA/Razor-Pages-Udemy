using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TasteRestaurant.Data;
using TasteRestaurant.Pages.ViewModels;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Pages.Order
{
    [Authorize]
    public class ManageOrderModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public ManageOrderModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public List<OrderTotalDetails> orderTotalDetails { get; set; }

        public async Task<IActionResult> OnGet()
        {
            orderTotalDetails = new List<OrderTotalDetails>();

            ClaimsIdentity claimIdentity = (ClaimsIdentity)this.User.Identity;

            Claim claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            string userId = claim.Value;

            var orderHeaderList = await _db.OrderHeader
                .Where(od => od.UserId == userId)
                .Where(odl => odl.Status == SD.StatusSubmited || odl.Status == SD.StatusPreparing)
                .OrderByDescending(hl => hl.OrderDate)
                .ToListAsync();

            foreach (var oh in orderHeaderList)
            {
                List<OrderDetails> orderDetails = _db.OrderDetails
                    .Where(od => od.OrderId == oh.Id)
                    .ToList();

                orderTotalDetails.Add(new OrderTotalDetails() { orderDetailsList = orderDetails, orderHeader = oh });
            }
            
            return Page();
        }

        public async Task<IActionResult> OnGetChangeOrderStatus(int? headerId ) 
        {     
            if (headerId == null)
            {
                return NotFound();
            }

            var currentOrderHeader = await _db.OrderHeader.SingleOrDefaultAsync(oh => oh.Id == headerId);

            switch (currentOrderHeader.Status)
            {
                case SD.StatusSubmited:
                    currentOrderHeader.Status = SD.StatusPreparing;
                    break;

                case SD.StatusPreparing:
                    currentOrderHeader.Status = SD.StatusPickUpReady;
                    break;

                case SD.StatusPickUpReady:
                    currentOrderHeader.Status = SD.StatusCompleted;
                    break;
                    
                default:
                    break;
            }

            _db.OrderHeader.Update(currentOrderHeader);

            await _db.SaveChangesAsync();

            return RedirectToPage(SD.ManageOrder);
        }

        public async Task<IActionResult> OnGetCancelOrder(int? headerId)
        {
            if (headerId == null){
                return NotFound();
            }

            var currentOrderHeader = await _db.OrderHeader.SingleOrDefaultAsync(oh => oh.Id == headerId);

            currentOrderHeader.Status = SD.StatusCancelled;
            
            _db.OrderHeader.Update(currentOrderHeader);

            await _db.SaveChangesAsync();

            return RedirectToPage(SD.ManageOrder);
        }
    }
}