namespace Meraki.Api.Data;

/// <summary>
/// Twilio settings
/// </summary>
[DataContract]
public class NetworkSettingsTwilio
{
    /// <summary>
    /// Twilio account SID
    /// </summary>
    [ApiAccess(ApiAccess.Read)]
    [DataMember(Name = "sid")]
    public string? Sid { get; set; }

    /// <summary>
    /// Twilio trial settings
    /// </summary>
    [ApiAccess(ApiAccess.Read)]
    [DataMember(Name = "trial")]
    public NetworkSettingsTwilioTrial? Trial { get; set; }
}
