using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class Client_Version_H
{
    public string IP_Address { get; set; } = null!;

    public string Program_Id { get; set; } = null!;

    public string? Cur_Ver_No { get; set; }

    public int? Cur_Seq_No { get; set; }

    public DateTime? Last_Update_Date { get; set; }

    public string? Last_Update_By { get; set; }

    public virtual ICollection<Client_Version_D> Client_Version_Ds { get; set; } = new List<Client_Version_D>();
}
