using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class DASHBOARDEXTEND
{
    public int ID { get; set; }

    public string? Url { get; set; }

    public string? Name { get; set; }

    public byte[]? Buffer { get; set; }

    public string? Type { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
