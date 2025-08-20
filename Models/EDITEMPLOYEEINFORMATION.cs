using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EDITEMPLOYEEINFORMATION
{
    public string Document { get; set; } = null!;

    public string? Employee { get; set; }

    public string? Status { get; set; }

    public string? Email { get; set; }

    public string? ProfessionalLicense { get; set; }

    public string? MobilePhone { get; set; }

    public string? PhoneNo { get; set; }

    public string? Marital { get; set; }

    public string? SpouseNameThai { get; set; }

    public string? SpouseNameEng { get; set; }

    public string? SpouseTel { get; set; }

    public DateTime? IDIssueDate { get; set; }

    public DateTime? IDExpDate { get; set; }

    public string Comid { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? ModifyBy { get; set; }
}
