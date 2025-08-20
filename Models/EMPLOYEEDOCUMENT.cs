using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class EMPLOYEEDOCUMENT
{
    public string Employee { get; set; } = null!;

    public string DocumentNo { get; set; } = null!;

    public string? DocumentName { get; set; }

    public DateTime? DocumentDate { get; set; }

    public DateTime? DocumentExpire { get; set; }

    public string? DocumentPicture { get; set; }

    public int? DocumentWarnning { get; set; }

    public byte[]? DocumentImage { get; set; }

    public string COMID { get; set; } = null!;

    public string? TypeWarning { get; set; }

    public DateTime? DateWarnning { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }

    public int? ImageID { get; set; }
}
