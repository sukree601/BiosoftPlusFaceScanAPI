using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CALCULATEHISTORY
{
    public DateTime? Dt { get; set; }

    public string? Period { get; set; }

    public byte[]? Times { get; set; }

    public string? COMID { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
