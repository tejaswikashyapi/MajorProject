using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseManagementSystem.Models
{
    public class Payer
    {
        public int? Id { get; set; }
        [ForeignKey(nameof(Payer.Id))]
        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name ="Payer Name")]
        [Required(ErrorMessage ="Please Enter Payer Name")]
        public string PayerName { get; set; }

        

    }
}
