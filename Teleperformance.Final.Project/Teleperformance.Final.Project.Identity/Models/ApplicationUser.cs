using Microsoft.AspNetCore.Identity;
using Teleperformance.Final.Project.Domain.ShopList;

namespace Teleperformance.Final.Project.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

     

    }
}
