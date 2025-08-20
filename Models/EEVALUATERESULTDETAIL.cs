using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATERESULTDETAIL
{
    public int CodeResultDetail { get; set; }

    public Guid CodeResult { get; set; }

    public string CodeIssue { get; set; } = null!;

    public string? CodeIssueDetail { get; set; }

    public string? Employee { get; set; }

    public string? CodePlan { get; set; }

    public decimal? Score { get; set; }

    public decimal? IssueScore { get; set; }

    public string? Detail { get; set; }

    public string ComID { get; set; } = null!;

    public string? Part { get; set; }

    public string? ManagerScore { get; set; }
}
