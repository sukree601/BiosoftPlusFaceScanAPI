namespace BiosoftPlusFaceScanAPI.Dtos;

public record CmiRecordItem(
    int EnrollId,
    string Time,
    int Mode,
    int InOut,
    int Event
);

public record CmiGetNewLogEnvelope(
    string Cmd,
    string? Sn,
    int Count,
    int LogIndex,
    List<CmiRecordItem>? Record
);

public record CmiDevInfo(
    string? ModelName,
    string? Firmware
// …เติมเท่าที่ใช้จริง
);

public record CmiRegEnvelope(
    string Cmd,
    string? Sn,
    CmiDevInfo? DevInfo
);
