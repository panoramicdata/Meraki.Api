namespace Meraki.Api.Data;

/// <summary>
/// Webhook test
/// </summary>
[DataContract]
public class WebhookTestRequest
{
	/// <summary>
	/// The type of alert which the test webhook will send. Optional. Defaults to power_supply_down
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "alertTypeId")]
	public string? AlertTypeId { get; set; }

	/// <summary>
	/// The ID of the payload template of the test webhook. Defaults to the HTTP server's template ID if one exists for the given URL, or Generic template ID otherwise
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "payloadTemplateId")]
	public string? PayloadTemplateId { get; set; }

	/// <summary>
	/// The name of the payload template.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "payloadTemplateName")]
	public string? PayloadTemplateName { get; set; }

	/// <summary>
	/// The shared secret the test webhook will send. Optional. Defaults to an empty string.
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "sharedSecret")]
	public string SharedSecret { get; set; } = string.Empty;

	/// <summary>
	/// The URL where the test webhook will be sent
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}
