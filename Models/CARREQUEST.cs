using System;
using System.Collections.Generic;

namespace BiosoftPlusFaceScanAPI.Models;

public partial class CARREQUEST
{
    public int ID { get; set; }

    public string? EmployeeID { get; set; }

    public DateOnly? DocDate { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? Destination { get; set; }

    public int? Person { get; set; }

    public string? Reason { get; set; }

    public string? TypeCar { get; set; }

    public string? Driver { get; set; }

    public string? Car { get; set; }

    public string? RequestStatus { get; set; }

    public DateOnly? RequestDate { get; set; }

    public string? RequestBy { get; set; }

    public string? COMID { get; set; }

    public string? ApproveStatus { get; set; }

    public DateOnly? ApproveDate { get; set; }

    public string? ApproveRemark { get; set; }

    public bool? SelfDrive { get; set; }

    public string? StatusDriveLicence { get; set; }

    public string? Department { get; set; }

    public string? Object { get; set; }

    public string? Priority { get; set; }

    public string? CarRegistation { get; set; }

    public string? WorkOfPlace { get; set; }

    public string? ReviewStatus { get; set; }

    public DateOnly? ReviewDate { get; set; }

    public DateOnly? ReviewBy { get; set; }

    public string? AttachFile { get; set; }

    public string? ObjectType { get; set; }

    public decimal? MileageStart { get; set; }

    public decimal? MileageEnd { get; set; }

    public string? RecheckSatus { get; set; }

    public DateOnly? RecheckDate { get; set; }

    public string? RecheckRemark { get; set; }
}
