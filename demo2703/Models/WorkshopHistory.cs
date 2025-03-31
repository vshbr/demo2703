using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class WorkshopHistory
{
    public int WorkshopHistoryId { get; set; }

    public TimeOnly TimeManufacturing { get; set; }

    public int PriceOld { get; set; }

    public int PriceNow { get; set; }

    public int Pricerange { get; set; }

    public int Costprice { get; set; }

    public int NecessaryMaterialsId { get; set; }
}
