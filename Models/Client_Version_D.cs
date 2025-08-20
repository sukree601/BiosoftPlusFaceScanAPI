using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class Client_Version_D
{
    public string IP_Address { get; set; } = null!;

    public string Program_Id { get; set; } = null!;

    public int Used_No { get; set; }

    public string Version_No { get; set; } = null!;

    public int Seq_No { get; set; }

    public DateTime? UpDate_Date { get; set; }

    public string? UpDate_By { get; set; }

    public virtual Client_Version_H Client_Version_H { get; set; } = null!;
}
