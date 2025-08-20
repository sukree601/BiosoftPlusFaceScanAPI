using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMAILSETUP
{
    public string EmailId { get; set; } = null!;

    public string? Type { get; set; }

    public string? CC { get; set; }

    public string? BCC { get; set; }

    public string? Subject { get; set; }

    public string? BestReagrs { get; set; }

    public string? Detail { get; set; }

    public string? COMID { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
