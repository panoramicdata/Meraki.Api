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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "payloadTemplateId")]
	public string? PayloadTemplateId { get; set; }

	/// <summary>
	/// The type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public PayloadTemplateType? Type { get; set; }

	/// <summary>
	/// Information on which entities have access to the template
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sharing")]
	public PayloadTemplateSharing? Sharing { get; set; }

	/// <summary>
	/// The headers
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "headers")]
	public List<PayloadTemplateHeader>? Headers { get; set; }

	/// <summary>
	/// The body
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "body")]
	public string? Body { get; set; }
}
