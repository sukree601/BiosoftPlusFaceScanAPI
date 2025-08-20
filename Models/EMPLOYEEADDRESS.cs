using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEEADDRESS
{
    public string Employee { get; set; } = null!;

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

    public int Line { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }

    public string? AddressNoEng { get; set; }

    public string? RoadEng { get; set; }

    public string? Contact { get; set; }

    public string? ContactEng { get; set; }

    public bool? Status { get; set; }

    public string? Name { get; set; }

    public string? LastName { get; set; }

    public string? Phon { get; set; }

    public string? Relation { get; set; }
}
