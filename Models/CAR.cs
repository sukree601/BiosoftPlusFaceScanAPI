using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CAR
{
    public string ID { get; set; } = null!;

    public string? CarID { get; set; }

    public string? Brand { get; set; }

    public string? Class { get; set; }

    public string? CarType { get; set; }

    public string? Type { get; set; }

    public string? Picture { get; set; }

    public bool? FixStatus { get; set; }

    public string? CarDescription { get; set; }

    public string? Color { get; set; }

    public string? COMID { get; set; }
}
