using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class BUSSTATION
{
    public string Code { get; set; } = null!;

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public string? Times { get; set; }

    public string? Busway { get; set; }

    public string? GroupType { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }

    public virtual ICollection<EMPLOYEE> EMPLOYEEs { get; set; } = new List<EMPLOYEE>();
}
