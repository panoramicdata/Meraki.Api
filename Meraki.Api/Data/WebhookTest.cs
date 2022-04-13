namespace Meraki.Api.Data;

/// <summary>
/// Webhook test
/// </summary>
[DataContract]
public class WebhookTest : IdentifiedItem
{
	/// <summary>
	/// The name of the test webhook
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

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

	/// <summary>
	/// The type of alert which the test webhook will send. Optional. Defaults to power_supply_down
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "alertTypeId")]
	public string? AlertTypeId { get; set; }
}
