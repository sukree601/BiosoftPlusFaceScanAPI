using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATEPERIOD
{
    public string EvaluatePeriod { get; set; } = null!;

    public string? EvaluateFrom { get; set; }

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public DateTime? FormDatePeriod { get; set; }

    public DateTime? ToDatePeriod { get; set; }

    public DateTime? OpenDate { get; set; }

    public DateTime? CloseDate { get; set; }

    public string? Status { get; set; }

    public string Comid { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public string? Average { get; set; }

    public bool? SelfEvaluation { get; set; }
}
