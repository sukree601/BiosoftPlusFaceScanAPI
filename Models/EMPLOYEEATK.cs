using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEEATK
{
    public int Id { get; set; }

    public string DocId { get; set; } = null!;

    public string? Employee { get; set; }

    public DateTime? DocDate { get; set; }

    public string? ATK { get; set; }

    public string? image { get; set; }

    public string? Comment { get; set; }

    public string COMID { get; set; } = null!;

    public string? Status { get; set; }
}
