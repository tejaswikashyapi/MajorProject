using System.ComponentModel.DataAnnotations;

namespace ExpenseManagementSystem.Models
{
    public class Payer
    {
        [Display(Name ="Payer Name")]
        [Required(ErrorMessage ="Please Enter Payer Name")]
        public string PayerName { get; set; }



    }
}
