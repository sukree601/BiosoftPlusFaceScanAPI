using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CHATROOMMEMBER
{
    public int ID { get; set; }

    public string RoomID { get; set; } = null!;

    public string Employee { get; set; } = null!;

    public string COMID { get; set; } = null!;

    public string CreateBy { get; set; } = null!;

    public string COMIDCreateBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
