using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class ELEANINGMASTER
{
    public string EleaningId { get; set; } = null!;

    public string? Subject { get; set; }

    public string? CreateFrom { get; set; }

    public string? msgDetail { get; set; }

    public string? Type { get; set; }

    public string? Examination { get; set; }

    public string? Detail { get; set; }

    public string? Division { get; set; }

    public string? Deparment { get; set; }

    public string? Position { get; set; }

    public int? ViewNumber { get; set; }

    public int? LikeNumber { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public string Comid { get; set; } = null!;
}
