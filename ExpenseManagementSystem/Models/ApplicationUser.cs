using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;
using Microsoft.AspNetCore.Identity;

namespace ExpenseManagementSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Please Enter Your Annual Income")]
        [Display(Name = "Annual Income")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UserIncome { get; set; }

        [Display(Name = "Registration Date")]
        [DataType(DataType.DateTime)]
        public DateTime UserCreatedOn { get; set; } = DateTime.Now;
    }
}
