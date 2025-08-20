using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CHECKPOINTCLIENT
{
    public int Id { get; set; }

    public string Employee { get; set; } = null!;

    public string? Reason { get; set; }

    public string ComID { get; set; } = null!;
}
