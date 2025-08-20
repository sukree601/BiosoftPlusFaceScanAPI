using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class DRIVER
{
    public string ID { get; set; } = null!;

    public string? TitleName { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? DrivingLicense { get; set; }

    public string? LicenseType { get; set; }

    public string? Picture { get; set; }

    public string? DriverDescription { get; set; }

    public string? COMID { get; set; }

    public string? DriverID { get; set; }

    public string? Employee { get; set; }
}
