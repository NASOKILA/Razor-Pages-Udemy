using TasteRestaurant.Data;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace TasteRestaurant.Utility
{
    public class DB
    {
        private readonly ApplicationDbContext _db;

        public DB(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CheckUserRole(string userEmail) {

            IdentityUser user = _db.Users.SingleOrDefault(u => u.Email == userEmail);
            
            var userRoleId = _db.UserRoles.SingleOrDefault(ur => ur.UserId == user.Id).RoleId;

            var userRoleName = _db.Roles.SingleOrDefault(r => r.Id == userRoleId).Name;
            
            return userRoleName == "Admin";
        }
    }
}
