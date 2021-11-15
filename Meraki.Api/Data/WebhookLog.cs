namespace Meraki.Api.Data;

[DataContract]
public class WebhookLog
{
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	[DataMember(Name = "alertType")]
	public string AlertType { get; set; } = string.Empty;

	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	[DataMember(Name = "sentAt")]
	public DateTime SentAt { get; set; }

	[DataMember(Name = "loggedAt")]
	public DateTime LoggedAt { get; set; }

	[DataMember(Name = "responseCode")]
	public int ResponseCode { get; set; }

	[DataMember(Name = "responseDuration")]
	public int ResponseDuration { get; set; }
}
