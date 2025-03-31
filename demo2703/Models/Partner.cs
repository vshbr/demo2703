using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class Partner
{
    public int Partnersid { get; set; }

    public int TypePartnersId { get; set; }

    public string Name { get; set; } = null!;

    public string? Uradress { get; set; }

    public string Inn { get; set; } = null!;

    public string Fio { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Logo { get; set; }

    public int RatingHistoryId { get; set; }

    public int Discount { get; set; }

    public int PlacesalesId { get; set; }

    public int HistorySalesId { get; set; }
}
