using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATEMASTERFORMDETAIL
{
    public int Id { get; set; }

    public string CodeForm { get; set; } = null!;

    public string CodeIssue { get; set; } = null!;

    public string? Detail { get; set; }

    public string CodeIssueDetail { get; set; } = null!;

    public decimal? IssueWeight { get; set; }

    public decimal? IssueScore { get; set; }

    public string ComID { get; set; } = null!;

    public int? Part { get; set; }

    public string? target { get; set; }

    public decimal? fromRank5 { get; set; }

    public decimal? toRank5 { get; set; }

    public decimal? fromRank4 { get; set; }

    public decimal? toRank4 { get; set; }

    public decimal? fromRank3 { get; set; }

    public decimal? toRank3 { get; set; }

    public decimal? fromRank2 { get; set; }

    public decimal? toRank2 { get; set; }

    public decimal? fromRank1 { get; set; }

    public decimal? toRank1 { get; set; }

    public int? No { get; set; }

    public string? PeriodEvaluateMasterForm { get; set; }
}
