using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class DataEventLog
{
    public int EventId { get; set; }

    public string? Period { get; set; }

    public int? Months { get; set; }

    public int? Years { get; set; }

    public DateTime? CrateDate { get; set; }

    public string? Times { get; set; }

    public string? Modules { get; set; }

    public string? Users { get; set; }

    public string? Message { get; set; }

    public string? Computer { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? PayDate { get; set; }

    public string COMID { get; set; } = null!;
}
