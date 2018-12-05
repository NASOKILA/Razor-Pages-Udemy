using System.Collections.Generic;
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
    public class OrderPickupModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public OrderPickupModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public List<OrderTotalDetails> orderTotalDetails { get; set; }

        [BindProperty]
        public SearchTypeViewModel searchTypeViewModel { get; set; }

        public async Task<IActionResult> OnGet()
        {
            orderTotalDetails = new List<OrderTotalDetails>();

            searchTypeViewModel = new SearchTypeViewModel();

            ClaimsIdentity claimIdentity = (ClaimsIdentity)this.User.Identity;

            Claim claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);

            string userId = claim.Value;

            var orderHeaderList = await _db.OrderHeader
                .Where(odl => odl.Status == SD.StatusPickUpReady)
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

        public async Task<IActionResult> OnPost()
        {
            if (searchTypeViewModel.SearchCriteria != null)
            {
                if (searchTypeViewModel.SearchText == null)
                    searchTypeViewModel.SearchText = "";

                switch (searchTypeViewModel.SearchCriteria)
                {
                    case SD.Name:

                        var currentUserByName = new ApplicationUser();

                        var allUsers = _db.Users.ToList();
                        foreach (var user in allUsers)
                        {
                            var appUser = (ApplicationUser)user;

                            if (appUser.FullName == searchTypeViewModel.SearchText)
                            {
                                currentUserByName = appUser;
                            }
                        }

                        if (currentUserByName != new ApplicationUser())
                        {
                            //user found list all his orders

                            var orderHeaderListName = await _db.OrderHeader
                                .Where(od => od.UserId == currentUserByName.Id)
                                .OrderByDescending(hl => hl.OrderDate)
                                .ToListAsync();

                            foreach (var oh in orderHeaderListName)
                            {
                                List<OrderDetails> orderDetails = _db.OrderDetails
                                    .Where(od => od.OrderId == oh.Id)
                                    .ToList();

                                orderTotalDetails.Add(new OrderTotalDetails() { orderDetailsList = orderDetails, orderHeader = oh });
                            }
                        }
                        else
                        {
                            // user not found
                            return Page();
                        }

                        break;

                    case SD.Email:

                        var userByEmail = await _db.Users
                            .SingleOrDefaultAsync(u => u.Email == searchTypeViewModel.SearchText);

                        if (userByEmail == null)
                        {

                            return Page();
                        }
                        else {

                            var orderHeaderListEmail = await _db.OrderHeader
                             .Where(odl => odl.UserId == userByEmail.Id)
                             .OrderByDescending(hl => hl.OrderDate)
                             .ToListAsync();

                            foreach (var oh in orderHeaderListEmail)
                            {
                                List<OrderDetails> orderDetails = _db.OrderDetails
                                    .Where(od => od.OrderId == oh.Id)
                                    .ToList();

                                orderTotalDetails.Add(new OrderTotalDetails() { orderDetailsList = orderDetails, orderHeader = oh });
                            }
                        }

                        break;

                    case SD.Phone:

                        var userByPhone = await _db.Users
                            .SingleOrDefaultAsync(u => u.Email == searchTypeViewModel.SearchText);

                        if (userByPhone == null)
                        {

                            return Page();
                        }
                        else
                        {
                            var orderHeaderListPhone = await _db.OrderHeader
                            .Where(odl => odl.UserId == userByPhone.Id)
                            .OrderByDescending(hl => hl.OrderDate)
                            .ToListAsync();

                            foreach (var oh in orderHeaderListPhone)
                            {
                                List<OrderDetails> orderDetails = _db.OrderDetails
                                    .Where(od => od.OrderId == oh.Id)
                                    .ToList();

                                orderTotalDetails.Add(new OrderTotalDetails() { orderDetailsList = orderDetails, orderHeader = oh });
                            }
                        }

                        break;

                    case SD.OrderNumber:


                        int number = -1;

                        try
                        {
                            number = int.Parse(searchTypeViewModel.SearchText);

                            var orderHeaderOrderNumber = await _db.OrderHeader
                                .SingleOrDefaultAsync(odl => odl.Id == number);
                             
                            List<OrderDetails> orderDetails = _db.OrderDetails
                                .Where(od => od.OrderId == orderHeaderOrderNumber.Id)
                                .ToList();
                             
                            orderTotalDetails.Add(new OrderTotalDetails() { orderDetailsList = orderDetails, orderHeader = orderHeaderOrderNumber });
                        }
                        catch
                        {
                        }


                        break;

                    default:
                        break;
                }
            }
            else
            {
                var orderHeaderList = await _db.OrderHeader
                          .Where(odl => odl.Status == SD.StatusPickUpReady)
                          .OrderByDescending(hl => hl.OrderDate)
                          .ToListAsync();

                foreach (var oh in orderHeaderList)
                {
                    List<OrderDetails> orderDetails = _db.OrderDetails
                        .Where(od => od.OrderId == oh.Id)
                        .ToList();

                    orderTotalDetails.Add(new OrderTotalDetails() { orderDetailsList = orderDetails, orderHeader = oh });
                }
            }

            return Page();
        }


    }
}