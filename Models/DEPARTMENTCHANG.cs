using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class DEPARTMENTCHANG
{
    public string Employee { get; set; } = null!;

    public int Line { get; set; }

    public string? JobTitle { get; set; }

    public string? DepartmentId { get; set; }

    public string? NewDepartmentId { get; set; }

    public string? Remark { get; set; }

    public string COMID { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
