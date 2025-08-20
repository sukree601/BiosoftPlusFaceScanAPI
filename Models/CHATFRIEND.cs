using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CHATFRIEND
{
    public int ID { get; set; }

    public string? RoomID { get; set; }

    public string FRIEND { get; set; } = null!;

    public string COMID { get; set; } = null!;

    public string CreateBy { get; set; } = null!;

    public string COMIDCreateBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? Type { get; set; }
}
