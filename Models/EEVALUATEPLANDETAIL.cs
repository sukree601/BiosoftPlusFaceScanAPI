using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATEPLANDETAIL
{
    public int Id { get; set; }

    public string CodePlan { get; set; } = null!;

    public string Period { get; set; } = null!;

    public string Employee { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public string ComID { get; set; } = null!;
}
