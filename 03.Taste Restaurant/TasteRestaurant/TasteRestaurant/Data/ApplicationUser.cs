using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TasteRestaurant.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped] // This will not register in the DB
        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
