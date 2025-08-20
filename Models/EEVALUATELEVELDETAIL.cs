using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATELEVELDETAIL
{
    public string Code { get; set; } = null!;

    public string CodeLevel { get; set; } = null!;

    public string? Name { get; set; }

    public int? FromScore { get; set; }

    public int? ToScore { get; set; }

    public string? Detail { get; set; }

    public string COMID { get; set; } = null!;
}
