using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MajorProjectExpenseManagementSystem.Models
{
    public partial class Expenses
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Expensedate { get; set; }
        public float Amount { get; set; }
        public string Payer { get; set; }
        public string Submittime { get; set; }
        public int? UserId { get; set; }
    }
}
