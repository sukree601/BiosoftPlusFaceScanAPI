using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CRIMINAL
{
    public string EmployeeRequest { get; set; } = null!;

    public string Criminal1 { get; set; } = null!;

    public string? Type { get; set; }

    public DateTime? CriminalDate { get; set; }

    public string? Remark { get; set; }

    public string? Status { get; set; }
}
