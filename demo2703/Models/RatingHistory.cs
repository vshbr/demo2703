using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class RatingHistory
{
    public int RatingHistoryId { get; set; }

    public int RaitingNow { get; set; }

    public int RaitingPast { get; set; }

    public DateOnly Date { get; set; }
}
