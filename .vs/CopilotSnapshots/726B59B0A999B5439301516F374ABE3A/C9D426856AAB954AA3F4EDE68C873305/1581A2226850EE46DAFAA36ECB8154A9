
using BiosoftPlusFaceScanAPI.Models;
using BiosoftPlusFaceScanAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
 
// Add services to the container.
builder.Services.AddSingleton<DeviceMonitor>();
builder.Services.AddHostedService<MonitorPrinter>();
builder.Services.AddControllers();
builder.Services.AddScoped<IAttendanceService, AttendanceService>();


builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Warning); // โชว์เฉพาะ Warning ขึ้นไป


// ลงทะเบียน DbContext
builder.Services.AddDbContext<AppDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.WebHost.UseUrls("http://0.0.0.0:1031");

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot"))
});
//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}


 


//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
