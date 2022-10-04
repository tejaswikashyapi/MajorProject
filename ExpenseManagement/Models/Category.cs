using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ExpenseManagement.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public virtual ApplicationUser? ApplicationUser { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Category Name is required.")]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [Display(Name ="Icon")]
        public string CategoryIcon { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name ="Type")]
        public string CategoryType { get; set; } = "Expense";

        [NotMapped]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? TitleWithIcon
        {
            get
            {
                return this.CategoryIcon + " " + this.CategoryName;
            }
        }
    }
}
