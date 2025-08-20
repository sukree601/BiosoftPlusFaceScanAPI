using System.Text.Json.Serialization;

namespace BiosoftPlusFaceScanAPI.Models
{ 

    public record CmiGetNewLogEnvelope
    {

        [JsonPropertyName("cmd")] public string? Cmd { get; init; }   // "reg"
        [JsonPropertyName("ret")] public string? Ret { get; init; }
        [JsonPropertyName("sn")] public string? Sn { get; init; }
        [JsonPropertyName("result")] public bool? Result { get; init; }
        [JsonPropertyName("count")] public int? Count { get; init; }
        [JsonPropertyName("from")] public int? From { get; init; }
        [JsonPropertyName("to")] public int? To { get; init; }
        [JsonPropertyName("record")] public List<CmiRecord>? Record { get; init; }
    }

    public record CmiRecord
    {
        [JsonPropertyName("enrollid")] public int EnrollId { get; init; }
        [JsonPropertyName("name")] public string? Name { get; init; }
        [JsonPropertyName("time")] public string Time { get; init; } // "yyyy-MM-dd HH:mm:ss"
        [JsonPropertyName("mode")] public int? Mode { get; init; }
        [JsonPropertyName("inout")] public int? InOut { get; init; }
        [JsonPropertyName("event")] public int? Event { get; init; }
    }

    public record CmiRegEnvelope
    {
        [JsonPropertyName("cmd")] public string? Cmd { get; init; }   // "reg"
        [JsonPropertyName("sn")] public string? Sn { get; init; }
        [JsonPropertyName("devinfo")] public CmiDevInfo? DevInfo { get; init; }
    }

    public record CmiDevInfo
    {
        [JsonPropertyName("modelname")] public string? ModelName { get; init; }
        [JsonPropertyName("usersize")] public int? UserSize { get; init; }
        [JsonPropertyName("facesize")] public int? FaceSize { get; init; }
        [JsonPropertyName("fpsize")] public int? FpSize { get; init; }
        [JsonPropertyName("palmsize")] public int? PalmSize { get; init; }
        [JsonPropertyName("cardsize")] public int? CardSize { get; init; }
        [JsonPropertyName("pwdsize")] public int? PwdSize { get; init; }
        [JsonPropertyName("logsize")] public int? LogSize { get; init; }

        [JsonPropertyName("useduser")] public int? UsedUser { get; init; }
        [JsonPropertyName("usedface")] public int? UsedFace { get; init; }
        [JsonPropertyName("usedfp")] public int? UsedFp { get; init; }
        [JsonPropertyName("usedpalm")] public int? UsedPalm { get; init; }
        [JsonPropertyName("usedcard")] public int? UsedCard { get; init; }
        [JsonPropertyName("usedpwd")] public int? UsedPwd { get; init; }
        [JsonPropertyName("usedlog")] public int? UsedLog { get; init; }
        [JsonPropertyName("usednewlog")] public int? UsedNewLog { get; init; }
        [JsonPropertyName("usedrtlog")] public int? UsedRtLog { get; init; }

        [JsonPropertyName("netinuse")] public int? NetInUse { get; init; }
        [JsonPropertyName("usb4g")] public int? Usb4G { get; init; }
        [JsonPropertyName("fpalgo")] public string? FpAlgo { get; init; }
        [JsonPropertyName("firmware")] public string? Firmware { get; init; }
        [JsonPropertyName("time")] public string? DeviceTime { get; init; }
        [JsonPropertyName("intercom")] public int? Intercom { get; init; }
        [JsonPropertyName("floors")] public int? Floors { get; init; }
        [JsonPropertyName("charid")] public int? CharId { get; init; }
        [JsonPropertyName("useosdp")] public int? UseOsdp { get; init; }
        [JsonPropertyName("dislanguage")] public int? DisLanguage { get; init; }
        [JsonPropertyName("curip")] public string? Ip { get; init; }
        [JsonPropertyName("mac")] public string? Mac { get; init; }

        // กันอนาคตฟิลด์อื่น ๆ
        [JsonExtensionData] public Dictionary<string, object>? Extra { get; init; }
    }

}
