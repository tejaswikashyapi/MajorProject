using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManagementSystem.Models
{
    [Table(name:"UserCategories")]
    public class UserCategory
    {
#nullable enable
        public string? Id { get; set; }


        [ForeignKey(nameof(UserCategory.Id))]
        public ApplicationUser ApplicationUser { get; set; }


        public string? ExpenseCategoryId { get; set; }


        [ForeignKey(nameof(UserCategory.ExpenseCategoryId))]
        public ExpenseCategory? ExpenseCategory { get; set; }
#nullable disable

    }
}
