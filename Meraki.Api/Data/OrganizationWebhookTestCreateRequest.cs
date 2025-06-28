namespace Meraki.Api.Data;

/// <summary>
/// Organization Webhook Test Create Request
/// </summary>
[DataContract]
public class OrganizationWebhookTestCreateRequest
{
	/// <summary>
	/// The type of alert which the test webhook will send. Optional. Defaults to insight_app_outage_start. default = "insight_app_outage_start"
	/// </summary>
	[DataMember(Name = "alertTypeId")]
	public string? AlertTypeId { get; set; }

	/// <summary>
	/// The ID of the payload template of the test webhook. Defaults to the HTTP server's template ID if one exists for the given URL, or Generic template ID otherwise
	/// </summary>
	[DataMember(Name = "payloadTemplateId")]
	public string? PayloadTemplateId { get; set; }

	/// <summary>
	/// The name of the payload template.
	/// </summary>
	[DataMember(Name = "payloadTemplateName")]
	public string? PayloadTemplateName { get; set; }

	/// <summary>
	/// The shared secret the test webhook will send. Optional. Defaults to an empty string.
	/// </summary>
	[DataMember(Name = "sharedSecret")]
	public string? SharedSecret { get; set; }

	/// <summary>
	/// The URL where the test webhook will be sent
	/// </summary>
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;
}
