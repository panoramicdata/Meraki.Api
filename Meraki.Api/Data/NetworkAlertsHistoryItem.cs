namespace Meraki.Api.Data;

/// <summary>
/// Network Alerts History Item
/// </summary>
[DataContract]
public class NetworkAlertsHistoryItem
{
	/// <summary>
	/// user friendly alert type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alertType")]
	public string AlertType { get; set; } = string.Empty;

	/// <summary>
	/// type of alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alertTypeId")]
	public string AlertTypeId { get; set; } = string.Empty;

	/// <summary>
	/// time when the event occurred
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "occurredAt")]
	public string OccurredAt { get; set; } = string.Empty;

	/// <summary>
	/// relevant data about the event that caused the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alertData")]
	public object AlertData { get; set; } = new();

	/// <summary>
	/// the destinations this alert is configured to be delivered to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "destinations")]
	public NetworkAlertsHistoryItemDestinations Destinations { get; set; } = new();

	/// <summary>
	/// info related to the device that caused the alert
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "device")]
	public NetworkAlertsHistoryItemDevice Device { get; set; } = new();
}
