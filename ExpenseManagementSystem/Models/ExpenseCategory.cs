using System.ComponentModel.DataAnnotations;

namespace ExpenseManagementSystem.Models
{
    public class ExpenseCategory
    {
        [Display(Name="Category ID")]
        [Key]
        public int ExpenseCategoryId { get; set; }

        [Required(ErrorMessage ="Please Enter Category Name")]
        [Display(Name ="Category Name")]
        public string ExpenseCategoryName { get; set; }
    }
}
