using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATERESULT
{
    public Guid CodeResult { get; set; }

    public string CodePlan { get; set; } = null!;

    public string? Employee { get; set; }

    public string? Manager { get; set; }

    public string? CodeForm { get; set; }

    public string? CodeLevel { get; set; }

    public int? Flow { get; set; }

    public string? Detail { get; set; }

    public string ComID { get; set; } = null!;

    public string? ScoreResult { get; set; }

    public string? LevelResult { get; set; }

    public string? ManagerLevelResult { get; set; }

    public string? CommitStatus { get; set; }

    public string? ManagerStatus { get; set; }

    public string? ManagerComment { get; set; }

    public string? HRStatus { get; set; }

    public string? HrComment { get; set; }

    public int? Cutpoints { get; set; }
}
