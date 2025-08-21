using System.Collections.Concurrent;

public record DeviceStatus(
    string Sn,
    string LastCmd,
    string LastIp,
    DateTime LastSeenUtc
);

public class DeviceMonitor
{
    private readonly ConcurrentDictionary<string, DeviceStatus> _map = new();
    public TimeSpan OnlineThreshold = TimeSpan.FromSeconds(90);

    public void Update(string sn, string cmd, string ip)
    {
        var now = DateTime.UtcNow;
        _map.AddOrUpdate(sn,
            _ => new DeviceStatus(sn, cmd, ip, now),
            (_, old) => old with { LastCmd = cmd, LastIp = ip, LastSeenUtc = now });
    }

    public IEnumerable<(DeviceStatus status, bool isOnline, TimeSpan age)> Snapshot()
    {
        var now = DateTime.UtcNow;
        foreach (var kv in _map.OrderBy(k => k.Key))
        {
            var age = now - kv.Value.LastSeenUtc;
            var online = age <= OnlineThreshold;
            yield return (kv.Value, online, age);
        }
    }
}
