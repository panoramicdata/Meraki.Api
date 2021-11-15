namespace Meraki.Api.Data;

/// <summary>
/// Webhook test
/// </summary>
[DataContract]
public class WebhookTest : IdentifiedItem
{
	/// <summary>
	/// The URL where the test webhook will be sent
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// The shared secret the test webhook will send. Optional. Defaults to an empty string.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; }

	/// <summary>
	/// Status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
