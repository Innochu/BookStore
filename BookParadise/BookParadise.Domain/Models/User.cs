using BookParadise.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace BookParadise.Domain.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public Cart Cart { get; set; } 
    }
}
