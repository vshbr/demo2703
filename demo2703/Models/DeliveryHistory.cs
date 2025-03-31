using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class DeliveryHistory
{
    public int DeliveryHistoryId { get; set; }

    public bool? Delivered { get; set; }

    public string Quantity { get; set; } = null!;

    public DateOnly Date { get; set; }
}
