namespace Meraki.Api.Data;

/// <summary>
/// webhook destinations for this alert
/// </summary>
[DataContract]
public class NetworkAlertsHistoryItemDestinationsWebhook
{
	/// <summary>
	/// time when the alert was sent to the user(s) for this channel
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sentAt")]
	public string SentAt { get; set; } = string.Empty;
}