using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEEADDRESSREFERENCE
{
    public string Employee { get; set; } = null!;

    public int Seq { get; set; }

    public string? NameEng { get; set; }

    public string? NameThai { get; set; }

    public string? AddressNoEng { get; set; }

    public string? AddressNoThai { get; set; }

    public string? AddressRoadEng { get; set; }

    public string? AddressRoadThai { get; set; }

    public string? AddressDistrictEng { get; set; }

    public string? AddressDistrictThai { get; set; }

    public string? AddressAmphurEng { get; set; }

    public string? AddressAmphurThai { get; set; }

    public string? PostCodeEng { get; set; }

    public string? PostCodeThai { get; set; }

    public string? ProvinceAddressEng { get; set; }

    public string? ProvinceAddressThai { get; set; }

    public string? PhoneAddressEng { get; set; }

    public string? PhoneAddressThai { get; set; }

    public string? MobileAddressEng { get; set; }

    public string? MobileAddressThai { get; set; }

    public string? OccupationEng { get; set; }

    public string? OccupationThai { get; set; }

    public string? RelationShipEng { get; set; }

    public string? RelationShipThai { get; set; }

    public string COMID { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
