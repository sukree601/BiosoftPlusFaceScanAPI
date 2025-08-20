using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class BRANCH
{
    public string Code { get; set; } = null!;

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? RegisterTax { get; set; }

    public string? RegisterSSO { get; set; }

    public string ComID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }

    public string? BankName { get; set; }

    public string? BankAcc { get; set; }

    public string? BankCode { get; set; }

    public string? TaxBranchNo { get; set; }

    public virtual ICollection<EMPLOYEEBRANCH> EMPLOYEEBRANCHes { get; set; } = new List<EMPLOYEEBRANCH>();

    public virtual ICollection<EMPLOYEE> EMPLOYEEs { get; set; } = new List<EMPLOYEE>();
}
