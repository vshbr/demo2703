using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace demo2703.Models;

public partial class RatingHistory
{
    public int RatingHistoryId { get; set; }

    [Range(0, Int32.MaxValue)]
    public int RaitingNow { get; set; }

    [Range(0, Int32.MaxValue)]
    public int RaitingPast { get; set; }

    public DateOnly Date { get; set; }
}
