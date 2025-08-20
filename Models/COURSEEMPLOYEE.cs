using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class COURSEEMPLOYEE
{
    public string Course { get; set; } = null!;

    public string Employee { get; set; } = null!;

    public string PlanCode { get; set; } = null!;

    public string? Status { get; set; }

    public string? Comment { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
