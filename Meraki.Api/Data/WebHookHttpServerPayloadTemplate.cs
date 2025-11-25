namespace Meraki.Api.Data;

/// <summary>
/// HTTP servers payload template reference
/// </summary>
[DataContract]
public class WebhookHttpServerPayloadTemplate
{
	/// <summary>
	/// The payload template ID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The payload template name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}