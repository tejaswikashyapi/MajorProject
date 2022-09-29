using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManagementSystem.Models
{
    [Table(name:"UserCategories")]
    public class UserCategory
    {
#nullable enable
        public string? Id { get; set; }


        [ForeignKey(nameof(UserCategory.Id))]
        public IdentityUser IdentityUser { get; set; }


        public string? ExpenseCategoryId { get; set; }


        [ForeignKey(nameof(UserCategory.ExpenseCategoryId))]
        public ExpenseCategory? ExpenseCategory { get; set; }
#nullable disable

    }
}
