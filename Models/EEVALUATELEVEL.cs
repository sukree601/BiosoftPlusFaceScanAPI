using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATELEVEL
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? Detail { get; set; }

    public string COMID { get; set; } = null!;
}
