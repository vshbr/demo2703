using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class Prepayment
{
    public int PrepaymentId { get; set; }

    public bool Check { get; set; }

    public int Prepayment1 { get; set; }

    public int CostProducts { get; set; }

    public int ProductsId { get; set; }
}
