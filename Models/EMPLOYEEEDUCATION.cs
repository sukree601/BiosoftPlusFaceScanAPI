using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEEEDUCATION
{
    public string Employee { get; set; } = null!;

    public int SequenceNo { get; set; }

    public string Institue { get; set; } = null!;

    public string? Degree { get; set; }

    public DateTime? StartYear { get; set; }

    public DateTime? EndYear { get; set; }

    public string? BranchEducation { get; set; }

    public string? Certificate { get; set; }

    public string? GPA { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
