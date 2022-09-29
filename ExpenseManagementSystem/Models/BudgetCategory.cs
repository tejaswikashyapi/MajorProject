using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ExpenseManagementSystem.Models
{
    public class BudgetCategory
    {
        [Display(Name ="Budget ID")]
        public int BudgetId { get; set; }

        [ForeignKey(nameof(BudgetCategory.BudgetId))]
        public Budget? Budget { get; set; }

        public int ExpenseCategoryId { get; set; }
        [ForeignKey(nameof(BudgetCategory.ExpenseCategoryId))]
        public ExpenseCategory? ExpenseCategory { get; set; }

        [Required(ErrorMessage = "Please Enter Budget Amount")]
        [Display(Name = "Budget Amount")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BudgetAmount { get; set; }

    }
}
