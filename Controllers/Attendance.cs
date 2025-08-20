using System;
using System.Globalization;
using System.Text.Json;
using BiosoftPlusFaceScanAPI.Data;
using BiosoftPlusFaceScanAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BiosoftPlusFaceScanAPI.Controllers
{
    [Route("api/attendance")]
    [ApiController]
    public class Attendance : ControllerBase
    {
        private readonly AppDb _db;

        public Attendance(AppDb db)
        {
            _db = db;
        }

        private static readonly JsonSerializerOptions JsonOpts = new()
        {
            PropertyNameCaseInsensitive = true
        };

        [HttpGet("gettime")]
        public async Task<IActionResult> GetTimeFaceAI()
        {
           var list =await _db.TEMPIMPORTs.Where(w => w.SourceType == "FaceAI").ToListAsync();

            return Ok(list);
        }

        [HttpPost("record")]
        public async Task<IActionResult> Record()
        {

            using var reader = new StreamReader(Request.Body);

            var rawData = await reader.ReadToEndAsync();
            Console.WriteLine($"----------------------------------------------------------------------------------");
            Console.WriteLine($"📨 Raw: {rawData}");

            return Ok();
        }

        [HttpPost("face-scan")]
        public async Task<IActionResult> FaceScan([FromBody] JsonElement payload)
        {

            var raw = payload.GetRawText();

            // 1) ลองเป็น getnewlog
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
                            var emp = _db.EmployeeScanTimeVIEW
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

                            int temp = _db.TEMPIMPORTs.Where(w => w.Employee == emp.Code && w.dt.Day == dt.Day
                            && w.dt.Month == dt.Month
                            && w.dt.Year == dt.Year
                            && w.Times == timeOnly).Count();

                            if (temp == 0)
                            {

                                var row = new TEMPIMPORT
                                {
                                    // ปรับชื่อพร็อพให้ตรงกับ entity จริงของคุณ
                                    Employee = emp.Code,
                                    dt = dt,
                                    Times = timeOnly,
                                    Hrs = hr,
                                    Mins = min,
                                    COMID = emp.COMID,
                                    CreateDate = dt,
                                    SourceType = "FaceAI"


                                };


                                _db.Set<TEMPIMPORT>().Add(row);
                                await _db.SaveChangesAsync();
                            }


                            //var re = r;
                            Console.WriteLine($"----------------------------------------------------------------------------------");
                            Console.WriteLine($"📨 Raw: {r.ToString()}");
                        }
                    }


                    var Succes = new
                    {
                        cmd = "getnewlog",
                        stn = true

                    };
                    return Ok(Succes);
                }
            }
            catch { /* ลองแบบอื่นต่อ */ }




            try
            {
                var r = JsonSerializer.Deserialize<CmiRegEnvelope>(raw, JsonOpts);
                if (r?.Cmd?.Equals("reg", StringComparison.OrdinalIgnoreCase) == true && r.DevInfo != null)
                {

                    return Ok(new
                    {
                        ret = "reg",
                        result = true,
                        cloudtime = DateTime.Now,
                        nosenduser = true
                    });
                }
            }
            catch { /* ตกลง unknown */ }





            //-----------------------------------------------------------------------------------

            using var reader = new StreamReader(Request.Body);

            var rawData = await reader.ReadToEndAsync();
            Console.WriteLine($"----------------------------------------------------------------------------------");
             Console.WriteLine($"📨 Raw: {rawData}");

            return Ok();

            //var Succes = new
            //{
            //    ret = "reg",
            //    result = true,
            //    cloudtime = DateTime.Now,
            //    nosenduser = true
            //};


            //var Succes = new
            //{
            //    cmd = "getnewlog",
            //    stn = true

            //};
            //return Ok(Succes); 
        }
   
    }
}
