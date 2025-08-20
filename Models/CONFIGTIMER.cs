using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CONFIGTIMER
{
    public string? ConfigWorkFlow { get; set; }

    public DateTime? DateMonthly { get; set; }

    public string? TimeMonthly { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string Type { get; set; } = null!;
}
