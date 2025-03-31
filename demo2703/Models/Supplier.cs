using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public int DeliveryHistoryId { get; set; }
}
