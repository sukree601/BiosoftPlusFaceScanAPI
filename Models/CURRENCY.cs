using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CURRENCY
{
    public string Code { get; set; } = null!;

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public Guid? rowguid { get; set; }
}
