namespace Meraki.Api.Data;

/// <summary>
/// The PayloadTemplate
/// </summary>
[DataContract]
public class PayloadTemplate : NamedItem
{
	/// <summary>
	/// The ID
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "payloadTemplateId")]
	public string PayloadTemplateId { get; set; } = string.Empty;

	/// <summary>
	/// The type
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public PayloadTemplateType Type { get; set; }

	/// <summary>
	/// The headers
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "headers")]
	public Dictionary<string, string> Headers { get; set; } = new();

	/// <summary>
	/// The body
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "body")]
	public string Body { get; set; } = string.Empty;
}
