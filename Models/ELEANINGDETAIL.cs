using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class ELEANINGDETAIL
{
    public int EleaningDetailId { get; set; }

    public string? EleaningId { get; set; }

    public string? Name { get; set; }

    public string? Path { get; set; }

    public string? Type { get; set; }

    public string Comid { get; set; } = null!;
}
