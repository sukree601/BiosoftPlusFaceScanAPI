using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class DEPARTMENTGROUP
{
    public string Code { get; set; } = null!;

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }

    public string? Section { get; set; }

    public string? Division { get; set; }

    public string? Department { get; set; }

    public bool? Status { get; set; }

    public string? Superintendent { get; set; }

    public string? CDCode { get; set; }

    public string? PMCode { get; set; }
}
