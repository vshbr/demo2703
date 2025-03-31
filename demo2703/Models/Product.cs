using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class Product
{
    public int ProductsId { get; set; }

    public string Articul { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public int SalesId { get; set; }

    public int WorkshopId { get; set; }

    public int Length { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int WeightWithoutPackaging { get; set; }

    public int WeightWithPackaging { get; set; }

    public string Certificate { get; set; } = null!;

    public int Number { get; set; }

    public string? ProductionTime { get; set; }

    public int WorkshopNumber { get; set; }

    public int NumberOfPeople { get; set; }
}
