using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManagementSystem.Models
{
    [Table(name:"Payers")]
    public class Payer
    {
        public int Id { get; set; }
        [Display(Name ="User Id")]
        [ForeignKey(nameof(Payer.Id))]
        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name ="Payer Name")]
        [Required(ErrorMessage ="Please Enter Payer Name")]
        public string PayerName { get; set; }

        

    }
}
