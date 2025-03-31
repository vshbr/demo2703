using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class Employee
{
    public int EmployeesId { get; set; }

    public DateOnly Date { get; set; }

    public string Fio { get; set; } = null!;

    public string? Passport { get; set; }

    public int? BankDetails { get; set; }

    public bool Family { get; set; }

    public int? HealthId { get; set; }

    public int RoleId { get; set; }

    public int RatingHistoryId { get; set; }
}
