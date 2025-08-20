using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class DataLogImport
{
    public int Id { get; set; }

    public DateTime? DateImport { get; set; }

    public string? FileName { get; set; }

    public string? SheetName { get; set; }

    public string? PathFileName { get; set; }

    public string? Tables { get; set; }

    public string? ColumnName { get; set; }

    public int? RowCounts { get; set; }

    public string? KeyLog { get; set; }

    public bool? StatusDelete { get; set; }

    public string? StatusImport { get; set; }

    public string? MsgError { get; set; }

    public string? Computer { get; set; }

    public string? COMID { get; set; }

    public string? CreateBy { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifyDate { get; set; }
}
