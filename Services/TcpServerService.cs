using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Net.Http;

public class TcpServerService : BackgroundService
{
    private readonly ILogger<TcpServerService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    public TcpServerService(ILogger<TcpServerService> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var listener = new TcpListener(IPAddress.Any, 5003);
        listener.Start();
        _logger.LogInformation("✅ TCP Server started on port 5003");

        while (!stoppingToken.IsCancellationRequested)
        {
            var client = await listener.AcceptTcpClientAsync(stoppingToken);
            using var stream = client.GetStream();

            byte[] buffer = new byte[4096];
            int bytesRead = await stream.ReadAsync(buffer, stoppingToken);
            string receivedData = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            _logger.LogInformation("📥 Received TCP: {data}", receivedData);

            // ส่ง HTTP POST ไปยัง API
            try
            {
                var clientHttp = _httpClientFactory.CreateClient();
                var content = new StringContent(receivedData, Encoding.UTF8, "application/json");

                var response = await clientHttp.PostAsync("http://localhost:5000/api/attendance/face-scan", content, stoppingToken);
                _logger.LogInformation("➡️ Forwarded to Web API: {status}", response.StatusCode);
            }
            catch (Exception ex)
            {
                _logger.LogError("❌ Error sending to Web API: {msg}", ex.Message);
            }

            client.Close();
        }
    }
}
