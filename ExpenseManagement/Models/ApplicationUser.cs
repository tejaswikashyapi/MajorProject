using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ExpenseManagement.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ICollection<Category> Categories { get; set; }
    }
}
