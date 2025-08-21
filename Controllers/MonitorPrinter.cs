using Microsoft.Extensions.Hosting;

public class MonitorPrinter : BackgroundService
{
    private readonly DeviceMonitor _monitor;
    private readonly TimeSpan _interval = TimeSpan.FromSeconds(3);

    // ANSI escape code สำหรับสี
    private const string Reset = "\u001b[0m";
    private const string Green = "\u001b[32m";
    private const string Red = "\u001b[31m";

    public MonitorPrinter(DeviceMonitor monitor) => _monitor = monitor;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.Clear();
            Console.WriteLine("Face/FP Devices - Checklive Monitor");
            Console.WriteLine($"Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine(new string('-', 100));
            Console.WriteLine(
                $"{"SN",-16} {"STATUS",-12} {"LAST CMD",-10} {"AGE",-10} {"LAST SEEN",-20} {"IP",-15}");
            Console.WriteLine(new string('-', 100));

            foreach (var (status, _, age) in _monitor.Snapshot())
            {
                bool isOnline = age.TotalSeconds <= 20; // ✅ 20 วิ
                string label = isOnline ? $"{Green}ONLINE{Reset}" : $"{Red}OFFLINE{Reset}";
                string ageStr = $"{(int)age.TotalSeconds,3}s";

                Console.WriteLine(
                    $"{status.Sn,-16} {label,-12} {status.LastCmd,-10} {ageStr,-10} " +
                    $"{status.LastSeenUtc.ToLocalTime():yyyy-MM-dd HH:mm:ss,-20} {status.LastIp,-15}");
            }

            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Note: ONLINE = <= 20s, OFFLINE = > 20s");
            await Task.Delay(_interval, stoppingToken);
        }
    }
}
