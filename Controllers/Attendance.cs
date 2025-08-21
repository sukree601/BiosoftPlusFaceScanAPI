using System;
using System.Globalization;
using System.Text.Json; 
using BiosoftPlusFaceScanAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BiosoftPlusFaceScanAPI.Controllers
{
    [Route("")]
    [ApiController]
    public class Attendance : ControllerBase
    {
        private readonly AppDb _db;
        private readonly DeviceMonitor _monitor;
        public Attendance(AppDb db, DeviceMonitor monitor)
        {
            _db = db;
            _monitor = monitor;
        }

        private static readonly JsonSerializerOptions JsonOpts = new()
        {
            PropertyNameCaseInsensitive = true
        };

        // ✅ Health check (GET /)
        [HttpGet("")]
        public IActionResult Health() => Ok(new { status = "ok" });



        [HttpPost("")]
        [HttpPost("face")]
        //[Consumes("application/json")]
        public async Task<IActionResult> FaceScan([FromBody] JsonElement payload)
        {

            var raw = payload.GetRawText();

            try
            {
                //var a = JsonSerializer.Deserialize<CmiGetNewLogEnvelope>(raw, JsonOpts);

                var a = JsonSerializer.Deserialize<CmiGetNewLogEnvelope>(raw, JsonOpts);
                if (a?.Cmd?.Equals("sendlog", StringComparison.OrdinalIgnoreCase) == true)
                {
                    var sn = a.Sn ?? "UNKNOWN";
                    //await UpsertDeviceAsync(sn);

                    if (a.Record is { Count: > 0 })
                    {


                        foreach (var r in a.Record)
                        {
                            string EnrollId = r.EnrollId.ToString();
                            var emp = _db.EmployeeScanTimeViews
                            .Where(e => e.Employee2 == EnrollId)
                            .AsNoTracking()
                            .FirstOrDefault();

                            if (emp == null || emp.Code == "")
                            {
                                continue;
                            }

                            DateTime dt = DateTime.ParseExact(r.Time, "yyyy-MM-dd HH:mm:ss", null);


                            int hr = dt.Hour;   // 12
                            int min = dt.Minute; // 22

                            // เอาเฉพาะชั่วโมง:นาที
                            string timeOnly = dt.ToString("HH:mm");

                            int temp = _db.Tempimports.Where(w => w.Employee == emp.Code && w.Dt.Day == dt.Day
                            && w.Dt.Month == dt.Month
                            && w.Dt.Year == dt.Year
                            && w.Times == timeOnly).Count();

                            if (temp == 0)
                            {

                                var row = new Tempimport
                                {
                                    // ปรับชื่อพร็อพให้ตรงกับ entity จริงของคุณ
                                    Employee = emp.Code,
                                    Dt = dt,
                                    Times = timeOnly,
                                    Hrs = hr,
                                    Mins = min,
                                    Comid = emp.Comid,
                                    CreateDate = dt,
                                    SourceType = "FaceAI"


                                };


                                _db.Set<Tempimport>().Add(row);
                                await _db.SaveChangesAsync();
                            }


                            //var re = r;
                            Console.WriteLine($"----------------------------------------------------------------------------------");
                            Console.WriteLine($"📨 Record: {r.ToString()}");
                        }
                    }



                    return Ok(new
                    {
                        cmd = "getnewlog",
                        stn = true
                    });
                }
            }
            catch { /* ลองแบบอื่นต่อ */ }




            try
            {
                var r = JsonSerializer.Deserialize<CmiRegEnvelope>(raw, JsonOpts);
                if (r?.Cmd?.Equals("reg", StringComparison.OrdinalIgnoreCase) == true && r.DevInfo != null)
                {

                    try
                    {

                        var chk_reg = await _db.Facescanregisters.Where(w => w.Sn == r.Sn).FirstOrDefaultAsync();
                        if (chk_reg == null)
                        {
                            var row = new Facescanregister
                            {
                                Sn = r.Sn,
                                Time = DateTime.Now,
                                Live = true,
                                Status = "reg"

                            };

                            _db.Set<Facescanregister>().Add(row);
                            await _db.SaveChangesAsync();
                        }
                       
                    }
                    catch {

                        return BadRequest();
                    }
                 
                    Console.WriteLine($"----------------------------------------------------------------------------------");
                    Console.WriteLine($"📨 reg : {raw}");

                    return Ok(new
                    {
                        ret = "reg",
                        result = true,
                        cloudtime = DateTime.Now,
                        nosenduser = true
                    });

                }

                if (r?.Cmd?.Equals("checklive", StringComparison.OrdinalIgnoreCase) == true )
                {

                    try
                    {
                        string remoteIp = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "-";
                        // อัปเดตสถานะลง Monitor
                        var sn = r.Sn ?? "UNKNOWN";
                        _monitor.Update(sn, "checklive", remoteIp);

                        var chk_live = await _db.Facescanregisters.Where(w => w.Sn == r.Sn).FirstOrDefaultAsync();
                        if (chk_live == null)
                        {
                            var row = new Facescanregister
                            {
                                Sn = r.Sn,
                                Time = DateTime.Now,
                                Live = true,
                                Status = "reg"
                            };

                            _db.Set<Facescanregister>().Add(row);
                            await _db.SaveChangesAsync();
                        }
                        
                        
                    }
                    catch
                    {

                        return BadRequest();
                    }

                    Console.WriteLine($"----------------------------------------------------------------------------------");
                    Console.WriteLine($"📨 checklive : {raw}");

                  
                    return Ok(new
                    {
                        ret= "checklive",
                        result= true
                    });
                }
            }
            catch { /* ตกลง unknown */ }





            //-----------------------------------------------------------------------------------

            //using var reader = new StreamReader(Request.Body);

            //var rawData = await reader.ReadToEndAsync();
            //Console.WriteLine($"----------------------------------------------------------------------------------");
            //Console.WriteLine($"📨 Raw: {raw}");

            return Ok();

            
        }
   
    }
}
