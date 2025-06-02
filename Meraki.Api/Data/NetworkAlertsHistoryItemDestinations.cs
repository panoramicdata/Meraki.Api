namespace Meraki.Api.Data;

/// <summary>
/// the destinations this alert is configured to be delivered to
/// </summary>
[DataContract]
public class NetworkAlertsHistoryItemDestinations
{
	/// <summary>
	/// email destinations for this alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "email")]
	public NetworkAlertsHistoryItemDestinationsEmail Email { get; set; } = new();

	/// <summary>
	/// push destinations for this alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "push")]
	public NetworkAlertsHistoryItemDestinationsPush Push { get; set; } = new();

	/// <summary>
	/// sms destinations for this alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sms")]
	public NetworkAlertsHistoryItemDestinationsSms Sms { get; set; } = new();

	/// <summary>
	/// webhook destinations for this alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "webhook")]
	public NetworkAlertsHistoryItemDestinationsWebhook Webhook { get; set; } = new();
}
