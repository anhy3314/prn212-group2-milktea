using System;
using System.Collections.Generic;

namespace PRN212_Group2_MilkTea_Repositories.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int UserPhone { get; set; }

    public int UserRole { get; set; }

    public int Bonus { get; set; }

    public byte? Status { get; set; }

    public virtual ICollection<Order> OrderCustomers { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderStaffs { get; set; } = new List<Order>();
}
