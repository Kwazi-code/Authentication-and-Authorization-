using Microsoft.AspNetCore.Identity;

namespace AuthSystem.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
