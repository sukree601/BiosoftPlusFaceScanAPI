using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CHATSTATUS
{
    public int ID { get; set; }

    public string? RoomID { get; set; }

    public string? ChatID { get; set; }

    public string EMPLOYEE { get; set; } = null!;

    public string COMID { get; set; } = null!;

    public string CreateBy { get; set; } = null!;

    public string COMIDCreateBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? Status { get; set; }
}
