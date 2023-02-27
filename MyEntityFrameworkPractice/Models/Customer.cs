using System;
using System.Collections.Generic;

namespace MyEntityFrameworkPractice.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public decimal Sales { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public override string ToString() {
        return $"CUSTOEMER : ID({Id,3}) - Customer {Name,-25} HQ:" +
            $" {City, 15}, {State} Sales: {Sales,-8:C}";
    }
}
