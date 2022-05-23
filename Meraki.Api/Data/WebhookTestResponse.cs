namespace Meraki.Api.Data;

/// <summary>
/// Webhook test
/// </summary>
[DataContract]
public class WebhookTestResponse : IdentifiedItem
{
	/// <summary>
	/// The URL where the test webhook will be sent
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

}
