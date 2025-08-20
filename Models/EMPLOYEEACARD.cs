using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEEACARD
{
    public string Employee { get; set; } = null!;

    public DateTime EffectiveDate { get; set; }

    public string? FromAcard { get; set; }

    public string? ToAcard { get; set; }

    public string? Comment { get; set; }

    public string ComId { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
