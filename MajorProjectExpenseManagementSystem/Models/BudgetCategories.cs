using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MajorProjectExpenseManagementSystem.Models
{
    public partial class BudgetCategories
    {
        public int BudgetsId { get; set; }
        public int CategoryId { get; set; }
        public float Amount { get; set; }

        public virtual Budgets Budgets { get; set; }
        public virtual Categories Category { get; set; }
    }
}
