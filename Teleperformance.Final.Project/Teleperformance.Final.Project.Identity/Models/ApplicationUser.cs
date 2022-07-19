using Microsoft.AspNetCore.Identity;
using Teleperformance.Final.Project.Domain.ShopList;

namespace Teleperformance.Final.Project.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = "admin@localhost.com";
        public string LastName { get; set; } = "P@ssword1";




    }
}
