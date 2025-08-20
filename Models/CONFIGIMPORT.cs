using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CONFIGIMPORT
{
    public string Code { get; set; } = null!;

    public string? Location { get; set; }

    public string? FormatDate { get; set; }

    public int? EmployeeFrom { get; set; }

    public int? EmployeeTo { get; set; }

    public int? DateFrom { get; set; }

    public int? DateTo { get; set; }

    public int? TimeFrom { get; set; }

    public int? TimeTo { get; set; }

    public int? StatusFrom { get; set; }

    public int? StatusTo { get; set; }

    public int? TerminalFrom { get; set; }

    public int? TerminalTo { get; set; }

    public string? PathDatabaseAcc { get; set; }

    public string? UserAcc { get; set; }

    public string? Password { get; set; }

    public string? FieldName { get; set; }

    public bool? UseAcc { get; set; }

    public string? FieldDate { get; set; }

    public string? FieldEmployee { get; set; }

    public string? FieldIO { get; set; }

    public string? FieldTerminal { get; set; }

    public string? Tables { get; set; }

    public int? Type { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? rowguid { get; set; }
}
