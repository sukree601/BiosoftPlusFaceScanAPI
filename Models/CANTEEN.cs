using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CANTEEN
{
    public string Employee { get; set; } = null!;

    public DateTime Dt { get; set; }

    public DateTime? ActiveDate { get; set; }

    public string Times { get; set; } = null!;

    public decimal? Total { get; set; }

    public decimal? Balance { get; set; }

    public string ComId { get; set; } = null!;
}
