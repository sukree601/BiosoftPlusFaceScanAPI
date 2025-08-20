using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CHATMESSAGE
{
    public int id { get; set; }

    public string RoomID { get; set; } = null!;

    public string receiver_id { get; set; } = null!;

    public string COMID { get; set; } = null!;

    public string message { get; set; } = null!;

    public string? Attachment { get; set; }

    public DateTime timestamp { get; set; }
}
