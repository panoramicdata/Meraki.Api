namespace Meraki.Api.Data;

/// <summary>
/// Twilio trial settings
/// </summary>
[DataContract]
public class NetworkSettingsTwilioTrial
{
    /// <summary>
    /// Trial counts
    /// </summary>
    [ApiAccess(ApiAccess.Read)]
    [DataMember(Name = "counts")]
    public NetworkSettingsTwilioTrialCounts? Counts { get; set; }
}
