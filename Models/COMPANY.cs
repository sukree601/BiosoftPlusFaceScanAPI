using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class COMPANY
{
    public string Code { get; set; } = null!;

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public byte[]? Logo { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Telephone { get; set; }

    public string? URL { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? RegisterNo { get; set; }

    public string? TaxBranchNo { get; set; }

    public string? SocialNumber { get; set; }

    public string? SocialBranch { get; set; }

    public decimal? SocialCompanyPer { get; set; }

    public decimal? SocialEmployeePer { get; set; }

    public decimal? SocialTotalPer { get; set; }

    public decimal? SocailMin { get; set; }

    public decimal? SocialMax { get; set; }

    public string? BankCode { get; set; }

    public string? AccNo { get; set; }

    public string? Acname { get; set; }

    public string? PFNo { get; set; }

    public string? PFName { get; set; }

    public string? PFComCode { get; set; }

    public DateTime? PayStartDate { get; set; }

    public DateTime? PayEndDate { get; set; }

    public string? ImagePath { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }

    public bool? ConfigManPower { get; set; }

    public int? ManPower { get; set; }

    public bool? ConfigUser { get; set; }

    public int? Users { get; set; }

    public string? WHDTAX { get; set; }

    public string? PND1K { get; set; }

    public string? REGEMPLOYEE { get; set; }

    public string? PathTimeImport { get; set; }

    public byte[]? Stamp { get; set; }

    public byte[]? CompanySignature { get; set; }

    public virtual ICollection<EMPLOYEE> EMPLOYEEs { get; set; } = new List<EMPLOYEE>();

    public virtual SETUP? SETUP { get; set; }

    public virtual registrator? registrator { get; set; }
}
