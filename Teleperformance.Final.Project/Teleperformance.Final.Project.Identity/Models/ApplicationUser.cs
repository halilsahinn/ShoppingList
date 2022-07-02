using Microsoft.AspNetCore.Identity;

namespace Teleperformance.Final.Project.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
