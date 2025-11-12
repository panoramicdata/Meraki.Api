namespace Meraki.Api.Data;

/// <summary>
/// Webhook Log
/// </summary>
[DataContract]
public class WebhookLog
{
	/// <summary>
	/// Gets the organization id
	/// </summary>
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// Gets the network id
	/// </summary>
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Gets the alert type
	/// </summary>
	[DataMember(Name = "alertType")]
	public string AlertType { get; set; } = string.Empty;

	/// <summary>
	/// Gets the url
	/// </summary>
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Gets the sent at
	/// </summary>
	[DataMember(Name = "sentAt")]
	public DateTime SentAt { get; set; }

	/// <summary>
	/// Gets the logged at
	/// </summary>
	[DataMember(Name = "loggedAt")]
	public DateTime LoggedAt { get; set; }

	/// <summary>
	/// Gets the response code
	/// </summary>
	[DataMember(Name = "responseCode")]
	public int ResponseCode { get; set; }

	/// <summary>
	/// Gets the response duration
	/// </summary>
	[DataMember(Name = "responseDuration")]
	public int ResponseDuration { get; set; }
}
