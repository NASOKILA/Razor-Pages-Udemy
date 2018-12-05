using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TasteRestaurant.Data;
using TasteRestaurant.Utility;

namespace TasteRestaurant.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
            _db = db;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = Input.Email,
                    Email = Input.Email,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    PhoneNumber = Input.PhoneNumber
                };

                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    //If there is no "User" role in the DB we create it !!!
                    if (!await _roleManager.RoleExistsAsync(SD.User)) {

                        var role = new IdentityRole();
                        role.Name = SD.User;
                        role.NormalizedName = SD.USER;

                        //await _db.Roles.AddAsync(role);
                        await _roleManager.CreateAsync(role);
                    }
                    
                    //We do the same for the "Admin" role
                    if (!await _roleManager.RoleExistsAsync(SD.Admin))
                    {
                        var role = new IdentityRole();
                        role.Name = SD.Admin;
                        role.NormalizedName = SD.ADMIN;

                        //await _db.Roles.AddAsync(role);
                        await _roleManager.CreateAsync(role);
                    }
                    
                    //if this is the first user we make it an admin
                    if (_db.Users.Count() < 2)
                    {
                        //We add a role to a user by using the _userManager
                        await _userManager.AddToRoleAsync(user, SD.Admin);

                        //IMPORTANT : Add the role claim to the user
                        await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, SD.Admin));
                    }
                    else
                    {
                        //If it is not the first user we assign it a User Role

                        //We add a role to a user by using the _userManager
                        await _userManager.AddToRoleAsync(user, SD.User);

                        //IMPORTANT : Add the role claim to the user
                        await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, SD.User));
                    }

                    
                    //Set the session CartCount ot 0
                    HttpContext.Session.SetInt32("CartCount", 0);
                    
                    _logger.LogInformation("User created a new account with password.");
                    
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
