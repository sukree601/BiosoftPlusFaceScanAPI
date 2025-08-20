using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATEPLANWORKFLOW
{
    public int GroupId { get; set; }

    public string EvaluateGroup { get; set; } = null!;

    public string? EmployeeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? ManagerCode { get; set; }

    public string? ManagerName { get; set; }

    public int Flow { get; set; }

    public string ComID { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public bool? Lock { get; set; }

    public bool? Status { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? PeriodFlow { get; set; }
}
