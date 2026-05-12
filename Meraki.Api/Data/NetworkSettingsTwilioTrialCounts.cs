namespace Meraki.Api.Data;

/// <summary>
/// Twilio trial counts
/// </summary>
[DataContract]
public class NetworkSettingsTwilioTrialCounts
{
    /// <summary>
    /// Remaining trial messages
    /// </summary>
    [ApiAccess(ApiAccess.Read)]
    [DataMember(Name = "remaining")]
    public int? Remaining { get; set; }
}
