using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MajorProjectExpenseManagementSystem.Models
{
    public partial class Payers
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
