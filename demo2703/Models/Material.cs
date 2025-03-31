using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class Material
{
    public int MaterialId { get; set; }

    public int TypeMaterialId { get; set; }

    public string Name { get; set; } = null!;

    public int Quantity { get; set; }

    public string Unitm { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Image { get; set; } = null!;

    public int? Price { get; set; }

    public int StorageId { get; set; }

    public int StoragyQuantity { get; set; }
}
