using System;
using System.Collections.Generic;

namespace MVCFinalProject.Models;

public partial class Claim
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public DateTime Date { get; set; }

    public int VehicleId { get; set; }
}
