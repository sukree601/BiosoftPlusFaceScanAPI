using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EDITEMPLOYEEADDRESS
{
    public string Employee { get; set; } = null!;

    public string DocumentRef { get; set; } = null!;

    public string? AddressNo { get; set; }

    public string? Road { get; set; }

    public string? District { get; set; }

    public string? Amphur { get; set; }

    public string? Province { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? PostCode { get; set; }

    public int Type { get; set; }

    public string COMID { get; set; } = null!;

    public Guid? rowguid { get; set; }

    public string? AddressNoEng { get; set; }

    public string? RoadEng { get; set; }

    public string? Contact { get; set; }

    public string? ContactEng { get; set; }

    public int Line { get; set; }
}
