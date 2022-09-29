using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManagementSystem.Models
{
    public class ExpenseCategory
    {
        [Display(Name="Category ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExpenseCategoryId { get; set; }

        [Required(ErrorMessage ="Please Enter Category Name")]
        [Display(Name ="Category Name")]
        public string ExpenseCategoryName { get; set; }
    }
}
