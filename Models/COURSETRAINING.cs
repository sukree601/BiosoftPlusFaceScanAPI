using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class COURSETRAINING
{
    public string Code { get; set; } = null!;

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public string? CourseType { get; set; }

    public string? Institue { get; set; }

    public decimal? Budget { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Comment { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
