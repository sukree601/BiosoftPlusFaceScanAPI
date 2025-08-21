
using BiosoftPlusFaceScanAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);


//// ✅ Add TCP BackgroundService
//builder.Services.AddHostedService<TcpServerService>();
//builder.Services.AddHttpClient(); // สำหรับส่ง HTTP POST

// Add services to the container.

builder.Services.AddControllers();

// ลงทะเบียน DbContext
builder.Services.AddDbContext<AppDb>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.WebHost.UseUrls("http://0.0.0.0:1400");

var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot"))
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



//app.MapPost("/device/reg", async (HttpRequest req) =>
//{

//    using var reader = new StreamReader(req.Body);
//    var body = await reader.ReadToEndAsync();

//    Console.WriteLine("Received Data:");
//    Console.WriteLine(body);

//    // TODO: คุณสามารถ Deserialize JSON, บันทึกลง DB, ตรวจสอบ SN, ฯลฯ
//    return Results.Ok(new { status = "received" });
//});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
