using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class TEMPIMPORT
{
    public string Employee { get; set; } = null!;

    public DateTime dt { get; set; }

    public string Times { get; set; } = null!;

    public string? IO { get; set; }

    public string? Terminal { get; set; }

    public int? Hrs { get; set; }

    public int? Mins { get; set; }

    public bool? OverDay { get; set; }

    public string COMID { get; set; } = null!;

    public bool? Lock { get; set; }

    public bool? SubShift { get; set; }

    public string? Shift { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? SourceType { get; set; }

    public string? DocumentNo { get; set; }

    public string? Status { get; set; }

    public bool? Flag { get; set; }

    public int? WorkCode { get; set; }
}
