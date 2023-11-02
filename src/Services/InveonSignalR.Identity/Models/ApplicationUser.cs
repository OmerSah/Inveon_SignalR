using Microsoft.AspNetCore.Identity;

namespace InveonSignalR.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
