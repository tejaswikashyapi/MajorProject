using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace ExpenseManagementSystem.Models
{
    public class Budget
    {
        [Required]
        [Key]
        public int BudgetId { get; set; }

        public string BudgetName { get; set; }
        public decimal BudgetAmount { get; set; }

        public DateAndTime BudgetCreatedOn { get; set; }
    }
}
