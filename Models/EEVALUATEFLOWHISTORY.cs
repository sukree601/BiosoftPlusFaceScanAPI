using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATEFLOWHISTORY
{
    public int GroupId { get; set; }

    public string? CodePlan { get; set; }

    public string? EvaluatePeriod { get; set; }

    public string? EvaluateGroup { get; set; }

    public string? EmployeeCode { get; set; }

    public string? ManagerCode { get; set; }

    public int? Flow { get; set; }

    public string ComID { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public bool? Lock { get; set; }

    public bool? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? PeriodFlow { get; set; }
}
