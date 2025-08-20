using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEEAPPROVE
{
    public string GroupCode { get; set; } = null!;

    public string EmployeeCode { get; set; } = null!;

    public string? Sequence { get; set; }

    public string COMID { get; set; } = null!;

    public string? Type { get; set; }
}
