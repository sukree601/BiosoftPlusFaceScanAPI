using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class DataLogFile
{
    public int EventId { get; set; }

    public string? Period { get; set; }

    public int? Months { get; set; }

    public int? Years { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? EmployeeEdit { get; set; }

    public string? PaymentControlOld { get; set; }

    public string? PaymentControlNew { get; set; }

    public string? AmountOld { get; set; }

    public string? AmountNew { get; set; }

    public string? FieldOld { get; set; }

    public string? FieldNew { get; set; }

    public string? Modules { get; set; }

    public string? Description { get; set; }

    public string? Message { get; set; }

    public string? Type { get; set; }

    public string? State { get; set; }

    public string? Users { get; set; }

    public string? Computer { get; set; }

    public string COMID { get; set; } = null!;

    public string? InTimeOld { get; set; }

    public string? InTimeNew { get; set; }

    public string? OutTimeOld { get; set; }

    public string? OutTimeNew { get; set; }

    public string? ShiftOld { get; set; }

    public string? ShiftInOld { get; set; }

    public string? ShiftOutOld { get; set; }

    public string? ShiftNew { get; set; }

    public string? ShiftInNew { get; set; }

    public string? ShiftOutNew { get; set; }

    public DateTime? DateTimeOld { get; set; }

    public DateTime? DateTimeNew { get; set; }
}
