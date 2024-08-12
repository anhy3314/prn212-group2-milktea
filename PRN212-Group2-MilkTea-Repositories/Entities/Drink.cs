using System;
using System.Collections.Generic;

namespace PRN212_Group2_MilkTea_Repositories.Entities;

public partial class Drink
{
    public int DrinkId { get; set; }

    public int CategoryId { get; set; }

    public string DrinkName { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public byte? DrinkStatus { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
