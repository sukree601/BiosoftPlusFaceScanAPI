using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CORRUPTION
{
    public int Id { get; set; }

    public string? EmployeeId { get; set; }

    public string? Photo { get; set; }

    public DateTime? Date { get; set; }

    public string? Times { get; set; }

    public string? Hrs { get; set; }

    public string? Min { get; set; }

    public string? Location { get; set; }

    public string? Lat { get; set; }

    public string? Lon { get; set; }

    public string? Type { get; set; }

    public string? ComId { get; set; }
}
