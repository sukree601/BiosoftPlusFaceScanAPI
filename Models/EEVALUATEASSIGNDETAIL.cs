using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATEASSIGNDETAIL
{
    public int AssignID { get; set; }

    public string? CodeForm { get; set; }

    public string? EvaluateGroup { get; set; }

    public string ComId { get; set; } = null!;

    public DateTime? CreateDate { get; set; }
}
