using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CHATROOM
{
    public int ID { get; set; }

    public string RoomID { get; set; } = null!;

    public string RoomName { get; set; } = null!;

    public string CreateBy { get; set; } = null!;

    public string COMIDCreateBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? Modifyby { get; set; }

    public string? COMIDModifyby { get; set; }

    public DateTime? Modifydate { get; set; }

    public string? Type { get; set; }

    public string? Attachment { get; set; }
}
