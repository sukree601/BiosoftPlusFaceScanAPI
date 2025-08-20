using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATEMASTERFORM
{
    public string CodeForm { get; set; } = null!;

    public string? Name { get; set; }

    public string? Detail { get; set; }

    public string ComID { get; set; } = null!;

    public string? PercentLevel { get; set; }

    public string? scoreing { get; set; }

    public string? typeEvaluate { get; set; }

    public bool? Cutpoints { get; set; }

    public string? Period { get; set; }

    public string? ScoreLevel { get; set; }

    public string? Topic { get; set; }

    public string? PeriodEvaluateMasterForm { get; set; }

    public bool? Lock { get; set; }

    public bool? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }
}
