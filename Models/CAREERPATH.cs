using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CAREERPATH
{
    public string CareerPathId { get; set; } = null!;

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public string? ComId { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    /// <summary>
    /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
    /// </summary>
    public Guid? rowguid { get; set; }
}
