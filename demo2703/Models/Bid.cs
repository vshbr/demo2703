using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class Bid
{
    public int BidId { get; set; }

    public string NameBid { get; set; } = null!;

    public bool Checkcomplite { get; set; }

    public int PrepaymentId { get; set; }

    public DateOnly Date { get; set; }

    public int EmployeesId { get; set; }

    public int ParntersId { get; set; }
}
