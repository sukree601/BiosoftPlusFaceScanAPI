using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class COMMENTDATION
{
    public int DocId { get; set; }

    public string Employee { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string? Title { get; set; }

    public string? Detail { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public DateTime? ActiveDate { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool? SendMail { get; set; }
}
