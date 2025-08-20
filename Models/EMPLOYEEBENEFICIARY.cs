using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEEBENEFICIARY
{
    public string Employee { get; set; } = null!;

    public int Orders { get; set; }

    public string Beneficiary { get; set; } = null!;

    public string? Relationship { get; set; }

    public decimal? Percents { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }
}
