using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EEVALUATECOMMENT
{
    public int Id { get; set; }

    public string? CodePlan { get; set; }

    public string? FormName { get; set; }

    public string? EmployeeOwner { get; set; }

    public string? EmployeeRecordCode { get; set; }

    public string? EmployeeRecordName { get; set; }

    public string? Role { get; set; }

    public string? RemarkDetail { get; set; }

    public string? Sort { get; set; }

    public string ComId { get; set; } = null!;
}
