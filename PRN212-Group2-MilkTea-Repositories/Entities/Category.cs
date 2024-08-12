using System;
using System.Collections.Generic;

namespace PRN212_Group2_MilkTea_Repositories.Entities;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Drink> Drinks { get; set; } = new List<Drink>();
}
