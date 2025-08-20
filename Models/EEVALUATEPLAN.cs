using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATEPLAN
{
    public string CodePlan { get; set; } = null!;

    public string CodeForm { get; set; } = null!;

    public string? Period { get; set; }

    public string? Detail { get; set; }

    public bool? Success { get; set; }

    public string? Complete { get; set; }

    public string? EvaluateGroup { get; set; }

    public string ComID { get; set; } = null!;
}
