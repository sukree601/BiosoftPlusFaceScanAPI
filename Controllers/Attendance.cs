using System.Text.Json;
using BiosoftPlusFaceScanAPI.Dtos;
using BiosoftPlusFaceScanAPI.Infra;
using BiosoftPlusFaceScanAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BiosoftPlusFaceScanAPI.Controllers;

[ApiController]
[Route("")]
public class AttendanceController : ControllerBase
{
    private static readonly JsonSerializerOptions JsonOpts = new() { PropertyNameCaseInsensitive = true };
    private readonly IAttendanceService _svc;
    private readonly ILogger<AttendanceController> _logger;

    public AttendanceController(IAttendanceService svc, ILogger<AttendanceController> logger)
    {
        _svc = svc;
        _logger = logger;
    }

    // GET /
    [HttpGet("")]
    public IActionResult Health() => Ok(new { status = "ok" });

    // POST / (และสำรอง /face เผื่อ firmware ต้องการ path segment)
    [HttpPost("")]
    [HttpPost("face")]
    public async Task<IActionResult> PostAsync([FromBody] JsonElement payload, CancellationToken ct)
    {
        string raw = payload.GetRawText();

        string? cmd = null;
        try
        {
            using var doc = JsonDocument.Parse(raw);
            cmd = doc.RootElement.TryGetProperty("cmd", out var c) ? c.GetString() : null;
        }
        catch
        {
            return BadRequest(ResponseFactory.BadJson());
        }

        if (string.IsNullOrWhiteSpace(cmd))
            return BadRequest(ResponseFactory.BadCmd(null));

        try
        {
            switch (cmd.ToLowerInvariant())
            {
                case "sendlog":
                    {
                        var a = JsonSerializer.Deserialize<CmiGetNewLogEnvelope>(raw, JsonOpts)!;
                        var resp = await _svc.HandleSendLogAsync(a, ct);
                        return Ok(resp);
                    }
                case "reg":
                    {
                        var r = JsonSerializer.Deserialize<CmiRegEnvelope>(raw, JsonOpts)!;
                        var resp = await _svc.HandleRegAsync(r, ct);
                        return Ok(resp);
                    }
                case "checklive":
                    {
                        var r = JsonSerializer.Deserialize<CmiRegEnvelope>(raw, JsonOpts)!;
                        var ip = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "-";
                        var resp = await _svc.HandleCheckLiveAsync(r, ip, ct);
                        return Ok(resp);
                    }
                default:
                    return BadRequest(ResponseFactory.BadCmd(cmd));
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error handling cmd {cmd}", cmd);
            return StatusCode(500, new { result = false, error = "server_error" });
        }
    }
}
