namespace Meraki.Api.Data;

/// <summary>
/// HTTP servers
/// </summary>
[DataContract]
public class WebhookHttpServerPayloadTemplate
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "payloadTemplateid")]
	public string? PayloadTemplateId { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}