using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class HistorySale
{
    public int HistorySalesId { get; set; }

    public int Quantity { get; set; }

    public DateOnly? Date { get; set; }

    public int ProductId { get; set; }
}
