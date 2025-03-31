using System;
using System.Collections.Generic;

namespace demo2703.Models;

public partial class Storage
{
    public int StorageId { get; set; }

    public int ProductsId { get; set; }

    public bool Instock { get; set; }

    public string Reserve { get; set; } = null!;

    public string WriteOff { get; set; } = null!;

    public string Admission { get; set; } = null!;

    public string Disposal { get; set; } = null!;

    public string Nowproduct { get; set; } = null!;

    public int WorkshophistoryId { get; set; }
}
