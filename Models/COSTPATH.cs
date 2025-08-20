using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class COSTPATH
{
    public string CostPathID { get; set; } = null!;

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public string? ComId { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }

    public virtual ICollection<EMPLOYEE> EMPLOYEEs { get; set; } = new List<EMPLOYEE>();
}
