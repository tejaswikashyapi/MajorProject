using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;

namespace ExpenseManagement.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransactionId { get; set; }
       

        [Range(1, int.MaxValue, ErrorMessage = "Please select a category.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Display(Name ="Amount")]
        [Range(1, int.MaxValue, ErrorMessage = "Amount should be greater than 0.")]
        public int TransactionAmount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? TransactionComment { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get
            {
                return Category == null ? "" : Category.CategoryIcon + " " + Category.CategoryName;
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.CategoryType == "Expense") ? "- " : "+ ") + TransactionAmount.ToString("C0");
            }
        }
    }
}
