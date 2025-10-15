using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BiosoftPlusFaceScanAPI.Models;

public class MonitorPrinter : BackgroundService
{
    private readonly DeviceMonitor _monitor;
    private readonly IServiceProvider _serviceProvider;
    private readonly IConfiguration _configuration;
    private readonly TimeSpan _interval = TimeSpan.FromSeconds(3);

    // ANSI escape code สำหรับสี
    //private const string Reset = "\u001b[0m";
    //private const string Green = "\u001b[32m";
    //private const string Red = "\u001b[31m";

    public MonitorPrinter(DeviceMonitor monitor, IServiceProvider serviceProvider, IConfiguration configuration) 
    {
        _monitor = monitor;
        _serviceProvider = serviceProvider;
        _configuration = configuration;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Console.Clear();
            Console.WriteLine("Face/FP Devices - Checklive Monitor");
            Console.WriteLine($"Updated: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            
            // แสดงจำนวนรายการจาก TEMPIMPORT table
            await DisplayTempImportCount();
            
            Console.WriteLine(new string('-', 100));
            Console.WriteLine(
                $"{"SN",-16} {"STATUS",-12} {"LAST CMD",-10} {"AGE",-10} {"LAST SEEN",-20} {"IP",-15}");
            Console.WriteLine(new string('-', 100));

            foreach (var (status, _, age) in _monitor.Snapshot())
            {
                bool isOnline = age.TotalSeconds <= 20; // ✅ 20 วิ
                string label = isOnline ? $"ONLINE" : $"OFFLINE";
                string ageStr = $"{(int)age.TotalSeconds,3}s";

                Console.WriteLine(
                    $"{status.Sn,-16} {label,-12} {status.LastCmd,-10} {ageStr,-10} " +
                    $"{status.LastSeenUtc.ToLocalTime():yyyy-MM-dd HH:mm:ss,-20} {status.LastIp,-15}");
            }

            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Note: ONLINE = <= 20s, OFFLINE = > 20s");
            
            // แสดงสถานะ server port ที่กำลังรันอยู่
            DisplayServerStatus();
            
            await Task.Delay(_interval, stoppingToken);
        }
    }

    private async Task DisplayTempImportCount()
    {
        try
        {
            using var scope = _serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDb>();
            
            var today = DateTime.Now.Date;
            var todayEnd = today.AddDays(1);
            
            var count = await dbContext.Tempimports
                .AsNoTracking()
                .CountAsync(t => t.Dt >= today 
                              && t.Dt < todayEnd 
                              && t.SourceType == "FaceAI");
            
            Console.WriteLine($"TEMPIMPORT Records Today (FaceAI): {count:N0} records");
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting TEMPIMPORT count: {ex.Message}");
            Console.WriteLine();
        }
    }

    private void DisplayServerStatus()
    {
        try
        {
            var serverHost = _configuration.GetValue<string>("ServerSettings:Host") ?? "localhost";
            var serverPort = _configuration.GetValue<int>("ServerSettings:Port", 5000);
            var serverUrl = $"http://{serverHost}:{serverPort}";
            
            Console.WriteLine();
            Console.WriteLine($"🌐 Server Status: Running on {serverUrl} | {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"🌐 Server Status: Running (Config Error: {ex.Message})");
        }
    }
}
