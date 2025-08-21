using System.Globalization;
using BiosoftPlusFaceScanAPI.Dtos;
using BiosoftPlusFaceScanAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BiosoftPlusFaceScanAPI.Services;

public interface IAttendanceService
{
    Task<object> HandleSendLogAsync(CmiGetNewLogEnvelope a, CancellationToken ct);
    Task<object> HandleRegAsync(CmiRegEnvelope r, CancellationToken ct);
    Task<object> HandleCheckLiveAsync(CmiRegEnvelope r, string remoteIp, CancellationToken ct);
}

public class AttendanceService : IAttendanceService
{
    private readonly AppDb _db;
    private readonly DeviceMonitor _monitor;
    private readonly ILogger<AttendanceService> _logger;

    public AttendanceService(AppDb db, DeviceMonitor monitor, ILogger<AttendanceService> logger)
    {
        _db = db;
        _monitor = monitor;
        _logger = logger;
    }

    public async Task<object> HandleSendLogAsync(CmiGetNewLogEnvelope a, CancellationToken ct)
    {
        string sn = a.Sn ?? "UNKNOWN";
        _monitor.Update(sn, "sendlog", "-");

        if (a.Record is not { Count: > 0 }) return Infra.ResponseFactory.SendLogOk();

        // เตรียม insert เป็น batch + กันซ้ำด้วยคีย์ (Employee, Dt.Date, Times)
        var rows = new List<Tempimport>();

        foreach (var r in a.Record)
        {
            var enrollId = r.EnrollId.ToString();
            var emp = await _db.EmployeeScanTimeViews
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Employee2 == enrollId, ct);

            if (emp is null || string.IsNullOrWhiteSpace(emp.Code)) continue;

            if (!DateTime.TryParseExact(r.Time, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out var dt))
            {
                //_logger.LogWarning("Invalid time format: {time}", r.Time);
                continue;
            }

            var timeOnly = dt.ToString("HH:mm", CultureInfo.InvariantCulture);

            bool exists = await _db.Tempimports.AsNoTracking()
                .AnyAsync(w => w.Employee == emp.Code
                               && w.Dt.Date == dt.Date
                               && w.Times == timeOnly, ct);
            if (exists) continue;

            rows.Add(new Tempimport
            {
                Employee = emp.Code,
                Dt = dt,
                Times = timeOnly,
                Hrs = dt.Hour,
                Mins = dt.Minute,
                Comid = emp.Comid,
                CreateDate = dt,
                SourceType = "FaceAI"
            });
        }

        if (rows.Count > 0)
        {
            _db.Tempimports.AddRange(rows);
            await _db.SaveChangesAsync(ct);
            //_logger.LogInformation("Inserted Tempimport rows: {cnt}", rows.Count);
        }

        return Infra.ResponseFactory.SendLogOk();
    }

    public async Task<object> HandleRegAsync(CmiRegEnvelope r, CancellationToken ct)
    {
        var sn = r.Sn ?? "UNKNOWN";
        _monitor.Update(sn, "reg", "-");

        var reg = await _db.Facescanregisters.FirstOrDefaultAsync(x => x.Sn == sn, ct);
        if (reg is null)
        {
            _db.Facescanregisters.Add(new Facescanregister
            {
                Sn = sn,
                Time = DateTime.Now,
                Live = true,
                Status = "reg"
            });
            await _db.SaveChangesAsync(ct);
        }

        return Infra.ResponseFactory.RegOk();
    }

    public async Task<object> HandleCheckLiveAsync(CmiRegEnvelope r, string remoteIp, CancellationToken ct)
    {
        var sn = r.Sn ?? "UNKNOWN";
        _monitor.Update(sn, "checklive", remoteIp);

        var row = await _db.Facescanregisters.FirstOrDefaultAsync(x => x.Sn == sn, ct);
        if (row is null)
        {
            _db.Facescanregisters.Add(new Facescanregister
            {
                Sn = sn,
                Time = DateTime.Now,
                Live = true,
                Status = "reg"
            });
        }
        else
        {
            row.Live = true;
            row.Time = DateTime.Now;
            row.Status = "checklive";
        }
        await _db.SaveChangesAsync(ct);

        return Infra.ResponseFactory.CheckLiveOk();
    }
}
