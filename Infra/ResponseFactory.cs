namespace BiosoftPlusFaceScanAPI.Infra;

public static class ResponseFactory
{
    public static object CheckLiveOk() => new { ret = "checklive", result = true };
    public static object RegOk() => new { ret = "reg", result = true, cloudtime = DateTime.Now, nosenduser = true };
    public static object SendLogOk() => new { cmd = "sendlog", stn = true , result = true };
    public static object BadCmd(string? cmd = null) => new { result = false, reason = $"unknown_cmd{(cmd is null ? "" : $"({cmd})")}" };
    public static object BadJson() => new { result = false, reason = "invalid_json" };
}
