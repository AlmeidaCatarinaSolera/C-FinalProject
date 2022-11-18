using System;
using System.Collections.Generic;

namespace MVCFinalProject.Models;

public partial class Vehicle
{
    public int Id { get; set; }

    public string Brand { get; set; } = null!;

    public string Vin { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int OwnerId { get; set; }


}
