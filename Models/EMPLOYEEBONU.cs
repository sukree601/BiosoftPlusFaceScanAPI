using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEEBONU
{
    public string Employee { get; set; } = null!;

    public DateTime ActiveDate { get; set; }

    public string Period { get; set; } = null!;

    public int? Age { get; set; }

    public string? Type { get; set; }

    public decimal? Salary { get; set; }

    public string? TypeRate { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Bonus { get; set; }

    public string? Remark { get; set; }

    public string? EvaluationPeriod { get; set; }

    public decimal? SpecailAmount { get; set; }

    public string? Grade { get; set; }

    public string? Position { get; set; }

    public string? PositionName { get; set; }

    public string? JobLevel { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
