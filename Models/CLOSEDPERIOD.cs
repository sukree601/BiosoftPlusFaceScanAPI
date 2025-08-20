using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CLOSEDPERIOD
{
    public int Code { get; set; }

    public byte[]? Period { get; set; }

    public int? Post { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
