using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManagementSystem.Models
{
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExpenseId { get; set; }

#nullable enable
        public int? Id { get; set; }
#nullable disable

        [ForeignKey(nameof(Expense.Id))]
        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please Enter Expense Description")]
        public string ExpenseDescription { get; set; }

        [Display(Name = "Expense Date")]
        [DataType(DataType.DateTime)]
        public DateTime ExpenseDate { get; set; }

        [Required(ErrorMessage = "Please Enter Expense Amount")] 
        [Display(Name = "Expense Amount")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ExpenseAmount { get; set; }

        public Payer PayerName { get; set; }

        public ExpenseCategory ExpenseCategoryName { get; set; }

        [Display(Name = "Submit DateTime")]
        [DataType(DataType.DateTime)]
        public DateTime SubmitDate { get; set; } = DateTime.Now;
    }
}
