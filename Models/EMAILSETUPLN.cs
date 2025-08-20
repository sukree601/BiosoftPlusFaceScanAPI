using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMAILSETUPLN
{
    public string EmailId { get; set; } = null!;

    public int Line { get; set; }

    public string? Employee { get; set; }

    public string? COMID { get; set; }

    public string? Type { get; set; }

    public bool? CrossCompany { get; set; }

    public string? TypeEmail { get; set; }

    public bool? Approve { get; set; }

    public bool? SendEmail { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }
}
