using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManagementSystem.Models
{
    [Table(name: "Budgets")]
    public class Budget
    {

        //Budget Id
        [Required(ErrorMessage ="Please Enter Budget ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BudgetId { get; set; }
        [Display(Name ="Budget Name")]
        public string BudgetName { get; set; }

        //User Id (Foreign Key)
        public int? Id { get; set; }
        [ForeignKey(nameof(Budget.Id))]
        public ApplicationUser? ApplicationUser { get; set; }

        //Budget Amount(decimal)
        [Required(ErrorMessage = "Please Enter Budget Amount")]
        [Display(Name = "Budget Amount")]
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BudgetAmount { get; set; }

        //Budget Created On(DateTime)
        [Display(Name = "Budget Date")]
        [DataType(DataType.DateTime)]
        public DateTime BudgetCreatedOn { get; set; } = DateTime.Now;
       
        //public ICollection<BudgetCategory> BudgetCategories { get; set; }
    }
}
